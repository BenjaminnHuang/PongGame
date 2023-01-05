using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;

    public Text playerScoreText;
    public Text computerScoreText;

    public Ball ball;
    
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public GameObject playerWinText;
    public GameObject computerWinText;

    public GameOverScreen GameOverScreen;
    public GameStopMenu GameStopMenu;

    private void Update() {
        if(Input.GetKey(KeyCode.Escape)){
            GameStopMenu.SetUp();
        }
    }
    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();

        if(_playerScore == 5){
            GameOverScreen.SetUp("You Win!");
        }
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();

        if(_computerScore == 5){
            GameOverScreen.SetUp("Computer Wins!");
        }
    }
}
