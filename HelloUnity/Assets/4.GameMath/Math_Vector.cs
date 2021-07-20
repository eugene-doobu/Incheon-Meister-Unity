using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math_Vector : MonoBehaviour
{
    void Start()
    {
        // 벡터
        Vector2 vector2_ = new Vector2(x: 1, y: 1);
        Vector3 vector3_ = new Vector3(x: 1, y: 1, z: 1);
        Vector4 vector4_ = new Vector4(x: 1, y: 1, z: 1, w: 1);

        // 벡터의 속기
        Vector3 rightVec = Vector3.right; // 1, 0, 0
        Vector3 upVec = Vector3.up; // 0, 1, 0
        Vector3 forwardVec = Vector3.forward; // 0, 0, 1

        // 벡터의 덧셈
        Vector3 sumA = new Vector3(2, 0, 4);
        Vector3 sumB = new Vector3(0, 3, 0);
        Debug.Log("sum: " +(sumA + sumB)); // 2, 3, 4

        // 벡터의 뺄셈
        // A - B 는 'B에서 A까지의 방향과 거리'를 의미한다.
        Vector3 subA = new Vector3(1, 0, 0);
        Vector3 subB = new Vector3(0, 0, 1);
        Debug.Log("sub: " + (subA - subB)); // 1, 0, -1
        // subB벡터를 (1, 0, -1) 만큼 이동시키면 subA와 같은 벡터가 된다.

        // 벡터의 스칼라 곱
        Vector3 scalarMul = new Vector3(1, 2, 3);
        Debug.Log("mul: " + (scalarMul * 3)); // 3, 6, 9

        // 벡터의 크기
        // 피타고라스의 정리 이용
        Vector2 mag = new Vector2(1, 1);
        Debug.Log("mag1: " + Mathf.Sqrt(mag.x * mag.x + mag.y * mag.y));
        Debug.Log("mag2: " + mag.magnitude);

        // 벡터의 정규화
        // 단위벡터: 크기가 1인 벡터(정규화된 벡터)
        // 벡터의 방향 자체를 나타냄
        Vector2 normalize = new Vector2(3, 5);
        Debug.Log("normalized1: " + (normalize / normalize.magnitude));
        Debug.Log("normalized2: " + normalize.normalized);

        // 벡터의 내적
        // 벡터의 내적의 결과는 스칼라

        // 벡터를 투영하는 연산
        // A dot B는 벡터 B를 A로 끌어내리는 연산

        // 벡터 사이의 각도를 구하는데 이용
        // 초월함수 사용은 피하는 것을 추천
        Vector2 dotA = new Vector2(0, 2);
        Vector2 dotB = new Vector2(3, 3);
        Debug.Log("Dot1: " + (dotA.x * dotB.x + dotA.y * dotB.y));
        Debug.Log("Dot2: " + (dotA.magnitude * dotB.magnitude * Mathf.Cos(45 * Mathf.Deg2Rad)));
        Debug.Log("Dot3: " + Vector2.Dot(dotA, dotB));

        // 벡터의 외적
        // 두 벡터를 모두 수직으로 통과하는 벡터를 구하는 연산
        // 어떤 표면에 수직인 방향(노말 벡터)를 구할 수 있음
        Vector3 crossA = new Vector3(1, 0, 0);
        Vector3 crossB = new Vector3(0, 0, 1);
        Debug.Log("AxB: " + Vector3.Cross(crossA, crossB));
        Debug.Log("BxA: " + Vector3.Cross(crossB, crossA));

        // 쿼터니언
        // 회전에 이용
        Quaternion quaternion = new Quaternion(x: 1, y: 1, z: 1, w: 1); // 회전을 표시

        // 직관적으로 이해하기 힘들기 때문에 오일러-쿼터니언 변환을 주로 사용
        Quaternion rotation = Quaternion.Euler(new Vector3(0, 45, 0));
        Vector3 eulerRotation = rotation.eulerAngles;
        Debug.Log("eToq: " + rotation);
        Debug.Log("qToe: " + eulerRotation);

        Quaternion a = Quaternion.Euler(30, 0, 0); // 0.0, 0.4, 0.0, 0.9
        Quaternion b = Quaternion.Euler(0, 0, 60); // 0, 45, 0

        // a만큼 회전 후 b만큼 회전시키는 쿼터니언
        Quaternion rotationProduct = a * b;
        Debug.Log("q*q: " + rotationProduct); // 0.2, -0.1, 0.5, 0.8

        // 행렬
        // 벡터 연산(선형 변환)에 이용
        Matrix4x4 m = new Matrix4x4(vector4_, vector4_, vector4_, vector4_);
        Debug.Log("mat4x4 :\n" + m); // 1로 가득찬 4x4 행렬

        Vector3 trs_pos = new Vector3(5, 0, 0); // x축으로 5만큼 평행이동
        Quaternion trs_rot = Quaternion.Euler(new Vector3(0, 90, 0)); // y축으로 90도 회전
        Vector3 trs_scale = new Vector3(2, 2, 2); // 스케일 2배
        Matrix4x4 trs = Matrix4x4.TRS(trs_pos, trs_rot, trs_scale);

        Vector4 obj = trs * Vector4.one;
        Debug.Log("trs : " + obj); // 7, 2, -2, 1

        obj = trs.inverse * obj;
        Debug.Log("trs inverse: " + obj); // 1, 1, 1, 1
    }
}
