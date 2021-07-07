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
        attack += () => Debug.Log("�⺻ ����!!");
        attack += () => Debug.Log("������ Ư��ȿ��!!");
        attack += () => Debug.Log("�нú� ��ų!!");
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
