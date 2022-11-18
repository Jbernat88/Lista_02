using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex_2 : MonoBehaviour
{
    Image timerBar;

    //Time duration
    public float maxTime = 5f;


    //Time left
    float timeLeft;

    void Start()
    {
        timerBar = GetComponent<Image>();

        //Time left    
        timeLeft = maxTime; 
    }

    void Update()
    {
        // When time is less than 0, the remaining time is subtracted from real time      
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
    }
}