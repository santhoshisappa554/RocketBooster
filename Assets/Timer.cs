using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   
    public float FuelAmount;
    public float PointdecreasedperSecond;

    private void Start()
    {
        FuelAmount = 10;
        PointdecreasedperSecond = 1;
    }
    private void Update()
    {
        if(FuelAmount >= 0)
        {
            FuelAmount -= PointdecreasedperSecond * Time.deltaTime;
            print("Score is:" + FuelAmount);
            
        }
        
    }
}
