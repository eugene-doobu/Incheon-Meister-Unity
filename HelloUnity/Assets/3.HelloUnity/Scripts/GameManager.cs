using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public GameManager instance;

    private int score = 0;
    private int goal = 0;
    private bool isWin = false;

    [SerializeField] GameObject winPanel = null;

    public int Score
    {
        get { return score; }
        set {
            score = value;
            if (score >= goal)
            {
                Debug.Log("Win!!");
                isWin = true;
                winPanel?.SetActive(true);
            }
        }
    }

    public bool IsWin
    {
        get { return isWin; }
    }

    private void Awake()
    {
        // ½Ì±ÛÅæ
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        // ¾À¿¡ Á¸ÀçÇÏ´Â CoinÀÇ °¹¼ö °¡Á®¿À±â
        var coins = FindObjectsOfType<Coin>();
        goal = coins.Length;
        Debug.Log("Num of coin = " + goal);
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
