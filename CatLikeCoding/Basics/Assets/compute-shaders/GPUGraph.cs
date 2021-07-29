using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Mathf;

public class GPUGraph : MonoBehaviour
{
	const int maxResolution = 1000;

	[SerializeField] ComputeShader computeShader;
	[SerializeField] FunctionLibrary.FunctionName function = default;
	[SerializeField] Material material;
	[SerializeField] Mesh mesh;
	[SerializeField, Range(10, maxResolution)] int resolution = 10;
	[SerializeField, Min(0f)] float functionDuration = 1f, transitionDuration = 1f;
	public enum TransitionMode { Cycle, Random }

	[SerializeField]
	TransitionMode transitionMode;

	float duration;

	bool transitioning;
	FunctionLibrary.FunctionName transitionFunction;

	ComputeBuffer positionsBuffer;

	static readonly int
		positionsId = Shader.PropertyToID("_Positions"),
		resolutionId = Shader.PropertyToID("_Resolution"),
		stepId = Shader.PropertyToID("_Step"),
		timeId = Shader.PropertyToID("_Time"),
		transitionProgressId = Shader.PropertyToID("_TransitionProgress");

	void UpdateFunctionOnGPU()
	{
		float step = 2f / resolution;
		computeShader.SetInt(resolutionId, resolution);
		computeShader.SetFloat(stepId, step);
		computeShader.SetFloat(timeId, Time.time);
		if (transitioning)
		{
			computeShader.SetFloat(
				transitionProgressId,
				SmoothStep(0f, 1f, duration / transitionDuration)
			);
		}

		var kernelIndex = 
			(int)function +
			(int)(transitioning ? transitionFunction : function) *
			FunctionLibrary.FunctionCount;;
		computeShader.SetBuffer(kernelIndex, positionsId, positionsBuffer);

		// [numthreads(8, 8, 1)]
		int groups = CeilToInt(resolution / 8f);
		computeShader.Dispatch(kernelIndex, groups, groups, 1);

		material.SetBuffer(positionsId, positionsBuffer);
		material.SetFloat(stepId, step);
		var bounds = new Bounds(Vector3.zero, Vector3.one * (2f + 2f / resolution));
		Graphics.DrawMeshInstancedProcedural(
					mesh, 0, material, bounds, resolution * resolution
				);
	}

	void OnEnable()
	{
		// 3개의 float(4)
		// -> 4만개기준, GPU에는 0.46MiB의 GPU 메모리가 필요
		positionsBuffer = new ComputeBuffer(maxResolution * maxResolution, 3 * 4);
	}

	void OnDisable()
	{
		positionsBuffer.Release();
		positionsBuffer = null;
	}

	void Update()
	{
		duration += Time.deltaTime;

		if (transitioning)
		{
			if (duration >= transitionDuration)
			{
				duration -= transitionDuration;
				transitioning = false;
			}
		}
		else if (duration >= functionDuration)
		{
			duration -= functionDuration;
			transitioning = true;
			transitionFunction = function;
			PickNextFunction();
		}

		UpdateFunctionOnGPU();
	}

	void PickNextFunction()
	{
		function = transitionMode == TransitionMode.Cycle ?
			FunctionLibrary.GetNextFunctionName(function) :
			FunctionLibrary.GetRandomFunctionNameOtherThan(function);
	}
}