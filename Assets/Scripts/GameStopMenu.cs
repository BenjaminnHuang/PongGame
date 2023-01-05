using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStopMenu : MonoBehaviour
{
    public void SetUp(){
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }
    public void Continue(){
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
