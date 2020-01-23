using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int score;

    public Text gameOverText;
    private bool gameOver;

    public Text restartText;
    private bool restart;

    // Start is called before the first frame update
    void Start()
    {
        restartText.text = "";
        restart = false;
        gameOverText.text = "";
        gameOver = false;
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 65)
        {
            GameSuccess();
        }
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "得分：" + score;
    }

    public void GameSuccess()
    {
        gameOver = true;
        gameOverText.text = "你成功啦";
        restart = true;
        restartText.text = "按R重新开始";
    }

    public void GameOver()
    {
        gameOver = true;
        gameOverText.text = "游戏结束";
        restart = true;
        restartText.text = "按R重新开始";
    }
}
