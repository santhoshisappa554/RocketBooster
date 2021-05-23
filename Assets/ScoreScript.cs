using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text FuelText;
    public float FuelAmount;
    public float PointdecreasedperSecond;
    public int Fuel;

    void Start()
    {

        FuelAmount = 10;//Amount of the Fuel of rocket
        PointdecreasedperSecond = 1;//decrement value of fuel
    }
    void FixedUpdate()
    {

        if (FuelAmount >= 0)//For the rocket to move it should have Fuel greater or eqaul to 1
        {
            FuelAmount -= PointdecreasedperSecond * Time.deltaTime;
            Fuel = Mathf.RoundToInt(FuelAmount);
            FuelText.text = "FuelAmount: " + Fuel;
            if (FuelAmount <= 0)
            {

                
                SceneManager.LoadScene(3);


            }


        }
    }
}
