using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public PlayerProfile playerProfile;
    public Dice dice;
    public TextMeshProUGUI Tmp;

    private void Update()
    {
        Tmp.text = playerProfile.PlayerNumber.ToString();
    }
    private void OnMouseDown()
    {
        playerProfile.rules();
        dice.randomNumber = 0;
    }
}
