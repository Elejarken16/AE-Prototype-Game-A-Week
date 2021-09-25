using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{
    int countDownStartValue = 10;
    public float totalTime; 
    public Text timerUI;
    public float currentTime = 10f;

    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if(countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "" + spanTime.Minutes + " : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "GameOver!";
            int buildindex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(buildindex);
        }
    }

    //void Update()
    //{
        //currentTime -= Time.deltaTime;
        //if (currentTime < 0)
        //{
            //int buildindex = SceneManager.GetActiveScene().buildIndex;
           // SceneManager.LoadScene(buildindex);
        //}
    //}


}
