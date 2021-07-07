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
