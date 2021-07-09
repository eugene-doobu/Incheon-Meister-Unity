using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public void _CoroutineTest()
    {
        StartCoroutine(RunIn3Second());
        StartCoroutine(RunInNextFrame());
        StartCoroutine(RunIn1Second());
        StartCoroutine(CoroutineInCoroutine());
    }

    IEnumerator RunInNextFrame()
    {
        yield return null;
        Debug.Log("Run In NextFrame");
    }

    IEnumerator RunIn1Second()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Run In 1 Second");
    }

    IEnumerator RunIn3Second()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("Run In 3 Second");
    }

    IEnumerator CoroutineInCoroutine()
    {
        yield return StartCoroutine(RunIn1Second());
        yield return StartCoroutine(RunIn3Second());
        Debug.Log("Coroutine In Coroutine");
    }
}
