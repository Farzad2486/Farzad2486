using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    public int randomNumber;
    public PlayerMove playerMove;
    void Start()
    {
    }

    void Update()
    {

    }

    public void RandomNumber()
    {
        randomNumber = Random.Range(1, 7);
        Debug.Log(randomNumber);
        if (randomNumber > 100 - playerMove.value)
        {
            Debug.Log("erorr");
        }
        else
        {
            if (playerMove.value == 0 & randomNumber == 6)
            {
                playerMove.value += 1;
            }
            else
            {
                if(playerMove.value > 0) 
                {
                    playerMove.value += randomNumber;
                }
            }
        }
    }
}
