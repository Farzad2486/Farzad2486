using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSystem : MonoBehaviour
{
    public bool PlayerTurn;
    void Start()
    {
        PlayerTurn = true;

    }
    public void Turn()
    {
        if (PlayerTurn)
        {
            Debug.Log("turn1");
            PlayerTurn = false;
        }
        else
        {
            Debug.Log("turn2");
            PlayerTurn = true;
        }
    }
}
