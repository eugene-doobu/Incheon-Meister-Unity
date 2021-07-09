using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalLoop : MonoBehaviour
{
    public void Coditional()
    {
        // if와 else
        if (true) // true or false
        {
            Debug.Log("조건문이 참인 경우 실행");
        }
        else
        {
            Debug.Log("조건문이 참이 아닌 경우 실행");
        }

        int a = 5;
        if(a <= 3)
        {
            Debug.Log("a가 3이하일때 실행");
        }
        else if(a >= 4){
            Debug.Log("a가 3이하가 아니면서 4이상일 때 실행");
        }
        else
        {
            Debug.Log("a가 3이하가 아니면서 4 이상이 아닐 때 실행");
        }

        // switch
        // 선택의 경우가 고정적인 경우 훨씬 직관적
        // 주로 함수와 Enum과 함께 사용
        switch (a)
        {
            case 1: Debug.Log("Case 1"); break;
            case 2: Debug.Log("Case 2"); break;
            case 3: // 생략시 다음 분기로 넘어감
            case 4: Debug.Log("Case 3 or 4"); break;
            case 5: Debug.Log("Case 5"); break;
            default: Debug.Log("Case Default"); break;
        }
    }

    public void ForLoop()
    {

    }

    public void WhileLoop()
    {

    }

    public void ForeachLoop()
    {
        List<int> list = new List<int>();
        for(int i=0; i<10; i++)
        {
            list.Add(i); // 0부터 9까지의 숫자 리스트에 저장
        }

        // 반복 가능한 컬렉션의 요소 반복
        foreach(int j in list)
        {
            Debug.Log("Foreach: " + j);
        }
    }
}
