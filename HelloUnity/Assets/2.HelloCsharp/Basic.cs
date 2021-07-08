#pragma warning disable CS0219

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    // �����ϸ� ���� ����Ʈ
    // https://www.csharpstudy.com/CSharp/CSharp-Intro.aspx

    public void Variables()
    {
        // integer
        short _short = 16; // 16��Ʈ 
        int _int = -32; // 32��Ʈ
        long _long = 64; // 64��Ʈ

        // unsigned integer
        uint _uint = 32; // 32��Ʈ

        // �ε��Ҽ���
        float _float = 32.32f; // 32��Ʈ
        double _double = 64.64; // 64��Ʈ

        bool _bool = false; // True of False

        char _char = 'c'; // 16��Ʈ
        string _string = "string"; // ���ڿ�

        Object obj = null; // ��� Ÿ���� �⺻ Ŭ����

        // ���
        const int cInt = 1234; // ������ ��� const. ������X
    }

    /*
     *  ���α׷����� �ᱹ ����� �ϴ� ���̱� ������,
     *  �����͸� �ְ� �ްų� ǥ�ø� �� �� ���ڿ��� �̿��ϰ� �ȴ�.
     *  �׸�ŭ ���ڿ� ó���� ���α׷��ֿ��� ���� ���Ǹ� �߿��ϴ�.
     */
    public void String()
    {
        // ����
        string str1 = "Hello " + "World!";
        Debug.Log(str1);

        // �̽������� ������
        string str2 = "Row 1\nRow 2\nRow 3";
        Debug.Log(str2);

        // Format
        string str3 = string.Format("{0} {1} {0}", 1, "is Number");
        Debug.Log(str3);

        string name = "David";
        int born = 2000;
        int published = 2021;
        string str4 = $"{name}�� {published - born}�쿡 å�� �����Ͽ���.";
        Debug.Log(str4);

    }

    public void Collections()
    {
        List<int> list = new List<int>();
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // ����Ʈ
        list.Add(3); // 3 �߰�
        list.Add(2); // 2 �߰�
        list.Add(1); // 1 �߰�
        list.Sort(); // �������� ����
        Debug.Log("����Ʈ�� ���� ����: " + list.Count);
        list.Remove(2); // ���� '2'�� ��� ����
        Debug.Log("2 ���� �� ���� ����: " + list.Count);
        list.Clear(); // ����Ʈ �ʱ�ȭ
        Debug.Log("�ʱ�ȭ �� ���� ����: " + list.Count);

        // ���� (LIFO, Last In First Out)
        stack.Push(14);
        stack.Push(35);
        stack.Push(42);
        Debug.Log("Pop:" + stack.Pop()); // 42 ���

        // ť (FIFO, First In Frist Out)
        queue.Enqueue(120);
        queue.Enqueue(130);
        queue.Enqueue(150);
        Debug.Log("Dequeue: " + queue.Dequeue()); // 120 ���

        // ��ųʸ�
        dict["number"] = 4115;
        dict["age"] = 18;
        dict["height"] = 175;
        Debug.Log(dict["number"]);
    }
}
