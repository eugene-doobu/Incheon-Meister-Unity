using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
    // 변수

    // 컬렉션



    public void Variables()
    {

    }

    /*
     *  프로그래밍은 결국 사람이 하는 것이기 때문에,
     *  데이터를 주고 받거나 표시를 할 때 문자열을 이용하게 된다.
     *  그만큼 문자열 처리는 프로그래밍에서 자주 사용되며 중요하다.
     */
    public void String()
    {
        // 덧셈

        // 곱셈

        // Format
    }

    public void Collections()
    {
        List<int> list = new List<int>();
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();
        Dictionary<string, int> dict = new Dictionary<string, int>();

        // 리스트
        list.Add(3);
        list.Add(2);
        list.Add(1);
        list.Sort();
        list.Remove(2);

        // 스택

        // 큐

        // 딕셔너리
        
    }
}
