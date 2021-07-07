using System.Linq;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Lambda : MonoBehaviour
{
    Action attack = null;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(() => Debug.Log("Dynamic Event Binding"));
    }

    private void Start()
    {
        attack += () => Debug.Log("기본 공격!!");
        attack += () => Debug.Log("아이템 특수효과!!");
        attack += () => Debug.Log("패시브 스킬!!");
    }

    public void Lambda1()
    {
        attack();
    }

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
