using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
        public Transform[] grid;
        public GameObject player;
        public int value;
    void Start()
    {
        
    }

    void Update()
    {
        player.transform.position = grid[value].transform.position;
    }
}
