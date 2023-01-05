using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text whoWins;
    public void SetUp(string wintext){
        gameObject.SetActive(true);
        whoWins.text = wintext;
        Time.timeScale = 0;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Quit(){
        Application.Quit();
    }
}
