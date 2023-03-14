using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] Paddle playerPaddle;
    [SerializeField] Paddle computerPaddle;
    [SerializeField] TextMeshProUGUI playerScoreText;
    [SerializeField] TextMeshProUGUI computerScoreText;
    public static int scorePlayer;
    public static int scoreComputer;

    private void Start()
    {
        setPlayerScore(0);
        setComputerScore(0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            NewGame();
        }

        if (scorePlayer == 5 || scoreComputer == 5)
        {
            SceneManager.LoadScene("EndScreen");
        }

    }

    public void PlayerScore()
    {
        scorePlayer++;
        playerScoreText.text = scorePlayer.ToString();
        RestartRound();
    }

    public void ComputerScore()
    {
        scoreComputer++;
        computerScoreText.text = scoreComputer.ToString();
        RestartRound();
    }

    public void NewGame()
    {
        setPlayerScore(0);
        setComputerScore(0);
        RestartRound();
    }

    public void RestartRound()
    {
        this.ball.ResetBallPosition();
        this.playerPaddle.ResetPositionPaddle();
        this.computerPaddle.ResetPositionPaddle();
        this.ball.AddStartForce();
    }

    void setPlayerScore(int score)
    {
        scorePlayer = score;
        playerScoreText.text = scorePlayer.ToString(); 
    }

    void setComputerScore(int score)
    {
        scoreComputer = score;
        computerScoreText.text = scoreComputer.ToString();
    }


}
