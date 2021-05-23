using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RocketMovement : MonoBehaviour
{
    public float RocketSpeed;
    public float Boostforce;
    public bool Fuel=false;
    public float FuelAmount;
    public float PointdecreasedperSecond;
  

    // Start is called before the first frame update
    void Start()
    {

        FuelAmount = 10;//Amount of the Fuel of rocket
        PointdecreasedperSecond = 1;//decrement value of fuel
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
                if (FuelAmount >= 0)//For the rocket to move it should have Fuel greater or eqaul to 1
                {
                    Fuel = true;
                   
                    FuelAmount -= PointdecreasedperSecond * Time.deltaTime;
                  
                  
                    if (FuelAmount <= 0)
                    {
                       Fuel = false;
                       
                    }
                   

            if (Fuel == true)//Movement of the rocket
                    {
                        if (Input.GetKey(KeyCode.RightArrow))
                        {
                            transform.Translate(Vector2.right * Time.deltaTime * RocketSpeed);
                        }
                        else if (Input.GetKey(KeyCode.LeftArrow))
                        {
                            transform.Translate(Vector2.left * Time.deltaTime * RocketSpeed);
                        }
                        BoostingMovement();
                    }
                }
            }
        
    
       
    public void OnCollisionEnter(Collision collision)
    {
        BoostingMovement();
    }
    private void BoostingMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, Boostforce)*Time.deltaTime);
        }
    }
       
}
