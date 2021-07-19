using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public void EndGame()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            print("Game Over!!!");
        }
    }
}
