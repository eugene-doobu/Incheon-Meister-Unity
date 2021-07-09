using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateEvent : MonoBehaviour
{
    // 델리게이트
    delegate void VoidDelegate();
    delegate int IntDelegate(int a, int b);
    IntDelegate intDelegate;
    VoidDelegate voidDelegate;

    // Action과 Func
    Action<int> action;  // 리턴값 없음
    Func<int, int> func; // 리턴값 존재

    // 이벤트


    void Start()
    {
        // 델리게이트에 함수를 넣을땐 괄호()를 넣지 않기
        // 일반적으로 대입 연산자에서
        //   a = 함수()   -> a에 함수의 실행결과 넣기
        //   a = 함수     -> a에 함수 자체를 넣기

        voidDelegate += HelloDelegate;
        intDelegate += AddFunc;
        action += ActionDebugInt;
        func += FuncReturnInt;
    }

    // 버튼 이벤트 함수
    public void _VoidDelegate()
    {
        voidDelegate();
    }

    public void _AddDelegate(int a)
    {
        Debug.Log(intDelegate(a, 5));
    }

    public void _ActionAndFunc(int a)
    {
        action(a);
        Debug.Log("Func Debug: " + func(a));
    }
    
    // 델리게이트용 함수
    private void HelloDelegate()
    {
        Debug.Log("Hello Delegate");
    }

    private int AddFunc(int a, int b)
    {
        return a + b;
    }

    private void ActionDebugInt(int a)
    {
        Debug.Log("Action Debug: " + a);
    }

    private int FuncReturnInt(int a)
    {
        return a;
    }
}
