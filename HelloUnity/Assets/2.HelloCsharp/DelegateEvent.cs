using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DelegateEvent : MonoBehaviour
{
    // ��������Ʈ
    delegate void VoidDelegate();
    delegate int IntDelegate(int a, int b);
    IntDelegate intDelegate;
    VoidDelegate voidDelegate;

    // Action�� Func
    Action<int> action;  // ���ϰ� ����
    Func<int, int> func; // ���ϰ� ����

    // �̺�Ʈ


    void Start()
    {
        // ��������Ʈ�� �Լ��� ������ ��ȣ()�� ���� �ʱ�
        // �Ϲ������� ���� �����ڿ���
        //   a = �Լ�()   -> a�� �Լ��� ������ �ֱ�
        //   a = �Լ�     -> a�� �Լ� ��ü�� �ֱ�

        voidDelegate += HelloDelegate;
        intDelegate += AddFunc;
        action += ActionDebugInt;
        func += FuncReturnInt;
    }

    // ��ư �̺�Ʈ �Լ�
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
    
    // ��������Ʈ�� �Լ�
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
