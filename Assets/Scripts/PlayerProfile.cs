using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerProfile : MonoBehaviour
{
    public string Team;
    public int PlayerNumber;
    public int PlayerValue;
    public PlayerMove playerMove;
    public Dice dice;
    public TurnSystem turnSystem;
    public Transform[] grid;
    public GameObject box;
    public Qte QteScript;
    //lerp
    public float Speed = 1;
    void Start()
    {

    }
    void Update()
    {
        QteScript.PlayerValue[PlayerNumber] = PlayerValue;

        if (!QteScript.QTE)
        {
            transform.position = Vector3.Lerp(transform.position, grid[PlayerValue].transform.position, Time.deltaTime * Speed);
        }

        if (turnSystem.PlayerTurn == Team)
        {
            if(PlayerValue == 0 & dice.randomNumber == 6)
            {
                box.SetActive(true);
                box.transform.position = grid[1].transform.position;
            }
            else
            {
                if(PlayerValue == 0 & dice.randomNumber < 6)
                {
                    box.SetActive(false);
                }
                else
                {
                    if(dice.randomNumber > 100 - PlayerValue)
                    {
                        box.SetActive(false);
                    }
                    else
                    {
                        if (PlayerValue == PlayerValue + dice.randomNumber)
                        {
                            box.SetActive(false);
                        }
                        else
                        {
                            box.SetActive(true);
                            box.transform.position = grid[PlayerValue + dice.randomNumber].transform.position;
                        }
                    }
                }
            }
        }
        else { box.SetActive(false);}
    }

    public void rules()
    {
        if (dice.randomNumber > 100 - PlayerValue)
        {
            Debug.Log("PlayerOneValue is Max");
        }
        else
        {
            if (PlayerValue == 0 & dice.randomNumber == 6 & turnSystem.PlayerTurn == Team)
            {
                PlayerValue += 1;
            }
            else
            {
                if (PlayerValue > 0 & turnSystem.PlayerTurn == Team)
                {
                    PlayerValue += dice.randomNumber;
                }
            }
        }
    }
}
