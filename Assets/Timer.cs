using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public bool TimerOn = false;


    public GameObject O1;
    public GameObject O2;
    public GameObject O3;
    public GameObject O4;
    public GameObject O5;
    public GameObject O6;
    public GameObject O7;
    public GameObject O8;
    public GameObject O9;
    public GameObject O10;

    public Text TimerTxt;

    void Start()
    {
        TimerOn = true;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 0;
                TimerOn = false;
            }
        }
        if (TimeLeft < 0)
        {
            O1.SetActive(false);
            O2.SetActive(false);
            O3.SetActive(false);
            O4.SetActive(false);
            O5.SetActive(false);
            O6.SetActive(false);
            O7.SetActive(false);
            O8.SetActive(false);
            O9.SetActive(true);
            O10.SetActive(true);
        }
    }

    public void reset()
    {
        SceneManager.LoadScene(0);
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{1:00}", minutes, seconds);
    }
}
