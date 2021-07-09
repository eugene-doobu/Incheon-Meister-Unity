using System.Linq;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Lambda : MonoBehaviour
{
    Action attack = null;
    Action<int> log = null;

    // 프로퍼티와 람다
    private int score;
    public int Score
    {
        get => score;
        set => score = value;
    }

    private void Awake()
    {
        // 람다와 AddListener
        GetComponent<Button>().onClick.AddListener(() => Debug.Log("Dynamic Event Binding"));
    }

    private void Start()
    {
        // 람다와 델리게이트 체인
        attack += () => Debug.Log("기본 공격!!");
        attack += () => Debug.Log("아이템 특수효과!!");
        attack += () => Debug.Log("패시브 스킬!!");

        // 람다 매개 변수 넣기
        log += n => Debug.Log("Log : " + n);
    }

    public void Lambda1()
    {
        attack();
        log(10);
    }

    // 람다와 LINQ
    public void LamdbaWithLINQ()
    {
        string[] names = { "Tom", "David", "Harry", "Mary", "Jay" };

        IEnumerable<string> query = names
            .Where(n => n.Contains("a"))
            .OrderBy(n => n.Length)
            .Select(n => n.ToUpper());

        foreach (string name in query)
        {
            Debug.Log(name);
        }
    }
}
