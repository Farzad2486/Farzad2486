using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
        public Transform[] grid;
        public GameObject PlayerOne;
        public GameObject PlayerTwo;
        public int PlayerOneValue;
        public int PlayerTwoValue;
    void Update()
    {
        PlayerOne.transform.position = grid[PlayerOneValue].transform.position;
        PlayerTwo.transform.position = grid[PlayerTwoValue].transform.position;
    }
}
