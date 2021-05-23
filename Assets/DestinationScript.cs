using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestinationScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)//if the rocket collidez with the destination then block returns true
    {
        if (collision.gameObject.CompareTag("rocket"))
        {
            print("You Won");
            
            Destroy(collision.gameObject, 0.0f);
            SceneManager.LoadScene(2);

        }
    }
   


}
