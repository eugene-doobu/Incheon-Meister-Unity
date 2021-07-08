#pragma warning disable CS0219

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    // 참조하면 좋은 사이트
    // https://www.csharpstudy.com/CSharp/CSharp-Intro.aspx

    public void Variables()
    {
        // integer
        short _short = 16; // 16비트 
        int _int = -32; // 32비트
        long _long = 64; // 64비트

        // unsigned integer
        uint _uint = 32; // 32비트

        // 부동소수점
        float _float = 32.32f; // 32비트
        double _double = 64.64; // 64비트

        bool _bool = false; // True of False

        char _char = 'c'; // 16비트
        string _string = "string"; // 문자열

        Object obj = null; // 모든 타입의 기본 클래스

        // 상수
        const int cInt = 1234; // 컴파일 상수 const. 참조값X
    }

    /*
     *  프로그래밍은 결국 사람이 하는 것이기 때문에,
     *  데이터를 주고 받거나 표시를 할 때 문자열을 이용하게 된다.
     *  그만큼 문자열 처리는 프로그래밍에서 자주 사용되며 중요하다.
     */
    public void String()
    {
        // 덧셈
        string str1 = "Hello " + "World!";
        Debug.Log(str1);

        // 이스케이프 시퀀스
        string str2 = "Row 1\nRow 2\nRow 3";
        Debug.Log(str2);

        // Format
        string str3 = string.Format("{0} {1} {0}", 1, "is Number");
        Debug.Log(str3);

        string name = "David";
        int born = 2000;
        int published = 2021;
        string str4 = $"{name}은 {published - born}살에 책을 출판하였다.";
        Debug.Log(str4);

    }

    public void Collections()
    {
        List<int> list = new List<int>();
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // 리스트
        list.Add(3); // 3 추가
        list.Add(2); // 2 추가
        list.Add(1); // 1 추가
        list.Sort(); // 오름차순 정렬
        Debug.Log("리스트의 원소 갯수: " + list.Count);
        list.Remove(2); // 값이 '2'인 요소 제거
        Debug.Log("2 제거 후 원소 갯수: " + list.Count);
        list.Clear(); // 리스트 초기화
        Debug.Log("초기화 후 원소 갯수: " + list.Count);

        // 스택 (LIFO, Last In First Out)
        stack.Push(14);
        stack.Push(35);
        stack.Push(42);
        Debug.Log("Pop:" + stack.Pop()); // 42 출력

        // 큐 (FIFO, First In Frist Out)
        queue.Enqueue(120);
        queue.Enqueue(130);
        queue.Enqueue(150);
        Debug.Log("Dequeue: " + queue.Dequeue()); // 120 출력

        // 딕셔너리
        dict["number"] = 4115;
        dict["age"] = 18;
        dict["height"] = 175;
        Debug.Log(dict["number"]);
    }
}
