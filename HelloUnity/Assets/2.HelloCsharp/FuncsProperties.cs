using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncsProperties : MonoBehaviour
{
    // 프로퍼티에 사용할 private 변수
    private int score;
    private int highScore;

    public int Score
    {
        get { return Score; }
        // set { score = value; }
    }

    public int HighScore
    {
        get { return highScore; }
        set
        {
            if (highScore <= value)
            {
                highScore = value;
            }
        }
    }

    // 자동 구현 프로퍼티
    public string Name { get; set; }
    public int Price { get; }
    //


    //
    public void Function()
    {
    }

    public void Property()
    {
        // 프로퍼티의 Get,Set
        score = 100;
        //Score = 50;
        Debug.Log("Get Score: " + score);

        // HighScore Set
        HighScore = 5;
        HighScore = 2;
        Debug.Log("HighScore: " + HighScore);
    }
    //

    private int Add(int a, int b)
    {
        return a + b;
    }

    private int Pow(ref int num)
    {
        int sign = 1;
        if (num < 0) sign = -1;

        num *= num;

        // 부호를 출력
        return sign;
    }
}
