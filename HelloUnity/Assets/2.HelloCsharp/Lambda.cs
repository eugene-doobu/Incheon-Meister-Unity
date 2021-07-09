using System.Linq;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Lambda : MonoBehaviour
{
    Action attack = null;
    Action<int> log = null;

    // ������Ƽ�� ����
    private int score;
    public int Score
    {
        get => score;
        set => score = value;
    }

    private void Awake()
    {
        // ���ٿ� AddListener
        GetComponent<Button>().onClick.AddListener(() => Debug.Log("Dynamic Event Binding"));
    }

    private void Start()
    {
        // ���ٿ� ��������Ʈ ü��
        attack += () => Debug.Log("�⺻ ����!!");
        attack += () => Debug.Log("������ Ư��ȿ��!!");
        attack += () => Debug.Log("�нú� ��ų!!");

        // ���� �Ű� ���� �ֱ�
        log += n => Debug.Log("Log : " + n);
    }

    public void Lambda1()
    {
        attack();
        log(10);
    }

    // ���ٿ� LINQ
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
