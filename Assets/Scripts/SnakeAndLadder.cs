using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class SnakeAndLatter : MonoBehaviour
{
    public int[] input;
    public int[] output;
    public PlayerMove playerMove;

    void Update()
    { 
        
        if (playerMove.PlayerOneValue == input[0]) 
        {
            playerMove.PlayerOneValue = output[0];
        }
        if (playerMove.PlayerOneValue == input[1])
        {
            playerMove.PlayerOneValue = output[1];
        }
        if (playerMove.PlayerOneValue == input[2])
        {
            playerMove.PlayerOneValue = output[2];
        }
        if (playerMove.PlayerOneValue == input[3])
        {
            playerMove.PlayerOneValue = output[3];
        }
    }
}
