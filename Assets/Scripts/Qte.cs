using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UI.Scrollbar;

public class Qte : MonoBehaviour
{
    public bool QTE;
    public Transform FightPosition;
    public Transform FightPosition1;
    public Transform FightPosition2;
    public PlayerMove playerMove;
    public Transform MainCamera;
    public Transform CameraPosition;
    public Transform FightCameraPosition;
    //scrollbar
    public Scrollbar scrollbar;
    private float maximum = 1;
    private float minimum = 0;
    private float ElapsedTime;
    public float Speed = 1;
    private float randomNumberFloat;
    public float Score;
    public bool stop;
    public Sprite[] sprites;
    private int randomNumber;
    public Image image;
    public ScrollEvent onValueChanged;
    void Start()
    {
        randomNumber = Random.Range(3, 9);
        image.sprite = sprites[randomNumber];
    }

    void Update()
    {
        if (playerMove.PlayerOneValue == playerMove.PlayerTwoValue)
        {
            QTE = true;
            if (playerMove.PlayerOneValue == 0 & playerMove.PlayerTwoValue == 0)
            {

            }
            else
            {
                MainCamera.position = FightCameraPosition.position;
                MainCamera.rotation = FightCameraPosition.rotation;
            }
            FightPosition.transform.position = playerMove.grid[playerMove.PlayerOneValue].transform.position;
            playerMove.PlayerOne.transform.position = FightPosition1.transform.position;
            playerMove.PlayerTwo.transform.position = FightPosition2.transform.position;
        }
        else
        {
            QTE = false;
            if (playerMove.PlayerOneValue == 0 & playerMove.PlayerTwoValue == 0)
            {

            }
            else
            {
                MainCamera.position = CameraPosition.position;
                MainCamera.rotation = CameraPosition.rotation;
            }
        }
        scrollbarVoid();
    }

    public void scrollbarVoid() 
    {
        randomNumberFloat = randomNumber;
        randomNumberFloat /= 10;
        Debug.Log(randomNumberFloat - scrollbar.value);

        if (!stop)
        {
            scrollbar.value = Mathf.Lerp(minimum, maximum, ElapsedTime);
            ElapsedTime += Speed * Time.deltaTime;

            if (Input.GetKeyDown(KeyCode.E))
            {
                stop = true;
                Debug.Log("stop");
                Score = randomNumberFloat -= scrollbar.value;
            }

            if (ElapsedTime > 1.0f)
            {
                float temp = maximum;
                maximum = minimum;
                minimum = temp;
                ElapsedTime = 0.0f;
            }
        }
    }
}
