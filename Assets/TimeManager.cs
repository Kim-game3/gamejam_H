using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class TimeManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TimeText;
    [SerializeField] int minute;
    [SerializeField] int second;
    float elapsedTime;
    bool counter_flag = false;

    // Start is called before the first frame update
    void Start()
    {
        minute = minute * 60;

        elapsedTime = minute + second;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TimeStart();
        }
        if (counter_flag)
        {
            elapsedTime -= Time.deltaTime;
        }

        TimeText.text = ((int)elapsedTime / 60).ToString() + ":" + ((int)elapsedTime % 60).ToString();
    }

    void TimeStart()
    {
        counter_flag = true;
    }
}