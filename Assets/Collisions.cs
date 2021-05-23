using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collisions : MonoBehaviour
{
   
    
    private void OnCollisionEnter(Collision collision)//if the rocket collidez with the environment or the obstacle block returns true
    {
        if (collision.gameObject.CompareTag("rocket"))
        {
            print("You Lost");
            Destroy(collision.gameObject, 0.0f);
            SceneManager.LoadScene(3);

        }
    }
    

}
