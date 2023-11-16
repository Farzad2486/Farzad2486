using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public int randomNumber;
    public PlayerMove playerMove;
    public TurnSystem turnSystem;
    public PlayerProfile[] playerProfile;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            RandomNumber();
        }
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (turnSystem.PlayerTurn == "Red")
            {
                playerProfile[1].rules();
                randomNumber = 0;
            }
            else
            {
                if(turnSystem.PlayerTurn == "Blue")
                {
                    playerProfile[3].rules();
                    randomNumber = 0;
                }
            }
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (turnSystem.PlayerTurn == "Red")
            {
                playerProfile[2].rules();
                randomNumber = 0;
            }
            else
            {
                if (turnSystem.PlayerTurn == "Blue")
                {
                    playerProfile[4].rules();
                    randomNumber = 0;
                }
            }
        }
    }
    public void RandomNumber()
    {
        //randomNumber
        randomNumber = Random.Range(1, 7);
        Debug.Log(randomNumber);

        //turnSystem
        turnSystem.Turn();
    }
}
