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
        playerMove.value += randomNumber;
    }
}
