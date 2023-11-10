using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    public int randomNumber;
    public PlayerMove playerMove;
    public TurnSystem turnSystem;

    public void RandomNumber()
    {
        //randomNumber
        randomNumber = Random.Range(1, 7);
        Debug.Log(randomNumber);

        //PlayerOne
        if (randomNumber > 100 - playerMove.PlayerOneValue)
        {
            Debug.Log("PlayerOneValue is Max");
        }
        else
        {
            if (playerMove.PlayerOneValue == 0 & randomNumber == 6 & turnSystem.PlayerTurn)
            {
                playerMove.PlayerOneValue += 1;
            }
            else
            {
                if(playerMove.PlayerOneValue > 0 & turnSystem.PlayerTurn) 
                {
                    playerMove.PlayerOneValue += randomNumber;
                }
            }
        }
        //PlayerTwo
        if (randomNumber > 100 - playerMove.PlayerTwoValue)
        {
            Debug.Log("PlayerTwoValue is Max");
        }
        else
        {
            if (playerMove.PlayerTwoValue == 0 & randomNumber == 6 & !turnSystem.PlayerTurn)
            {
                playerMove.PlayerTwoValue += 1;
            }
            else
            {
                if (playerMove.PlayerTwoValue > 0 & !turnSystem.PlayerTurn)
                {
                    playerMove.PlayerTwoValue += randomNumber;
                }
            }
        }

        //turnSystem
        turnSystem.Turn();
    }
}
