using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUI : MonoBehaviour
{
    Text text;
    float time = 0f;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        // 게임중이라면 플레이시간 증가
        if (!GameManager.instance.IsWin)
        {
            time += Time.deltaTime;
        }

        // 게임매니저에서 Score 가져오기
        int score = GameManager.instance.Score;

        // Format함수를 이용하여 출력하기
        text.text = string.Format("Score: {0}\nTime: {1:0.00}", score, time);
    }
}
