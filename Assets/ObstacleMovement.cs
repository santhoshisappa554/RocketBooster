using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float obstacleSpeed = 10;// speed of the movement of the obstacle
    
    private void FixedUpdate()
    {
        /*void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "LeftBorder")
        {
            transform.Translate(0, obstacleSpeed*Time.deltaTime, 0);
            print("Hit the Left Border");
        }
        if (collision.gameObject.name == "Block4")
        {
            transform.Translate(0,-obstacleSpeed*Time.deltaTime, 0);
            print("Hit the Block4");
        }
    }*/
        transform.Translate(0,obstacleSpeed * Time.deltaTime, 0);//movement of the obstacle from left to right on x-axis
        if (transform.position.x>= 5.07)
        {
            obstacleSpeed = 5;
        }
       else if (transform.position.x <= 2.68)
        {
            obstacleSpeed = -5;
        }
     

}
}
