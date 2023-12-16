using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    //ENCAPSULATION
    public static Counter Instance { get; private set; }
    public Text CounterText;

    private int Count = 0;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Count = 0;
    }

    public void IncreaseScore(int pointsToAdd)
    {
        Count += pointsToAdd;
        CounterText.text = "Count: " + Count.ToString();
    }
}
