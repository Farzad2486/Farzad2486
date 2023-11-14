using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform[] grid;
    public GameObject PlayerOne;
    public GameObject PlayerTwo;
    public GameObject[] Players;
    public int PlayerOneValue;
    public int PlayerTwoValue;
    public Qte QteScript;
    void Update()
    {
        if (!QteScript.QTE)
        {
            PlayerOne.transform.position = grid[PlayerOneValue].transform.position;
            PlayerTwo.transform.position = grid[PlayerTwoValue].transform.position;
        }
    }
}
