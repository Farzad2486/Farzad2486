using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public string PlayerTurn;
    void Start()
    {
        PlayerTurn = "Red";
    }
    public void Turn()
    {
        if (PlayerTurn == "Red")
        {
            Debug.Log("Blue");
            PlayerTurn = "Blue";
        }
        else
        {
            Debug.Log("Red");
            PlayerTurn = "Red";
        }
    }
}
