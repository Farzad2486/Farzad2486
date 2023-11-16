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
    //for
    public int[] PlayerValue;
    int count;
    //scrollbar
    public Scrollbar scrollbar1;
    public Scrollbar scrollbar2;
    private float maximum = 1;
    private float minimum = 0;
    private float ElapsedTime;
    public float Speed = 1;
    private float randomNumberFloat;
    public float Score1;
    public float Score2;
    public bool PlayerOneStop;
    public bool PlayerTwoStop;
    public Sprite[] sprites;
    private int randomNumber;
    public int test;
    public Image image1;
    public Image image2;
    void Start()
    {
        randomNumber = Random.Range(3, 9);
        image1.sprite = sprites[randomNumber];
        image2.sprite = sprites[randomNumber];
    }

    void Update()
    {
        if (!QTE)
        {
            for (int i = 0; i < PlayerValue.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < PlayerValue.Length; j++)
                {
                    if (PlayerValue[i] == PlayerValue[j])
                    {
                        count++;
                        PlayerValue[j] = 0;
                    }
                }
                if (count > 1 && PlayerValue[i] != 0)
                {
                    Debug.Log(PlayerValue[i]);
                    QTE = true;
                    test = i;
                    if (PlayerValue[i] == 0)
                    {

                    }
                    else
                    {
                        MainCamera.position = FightCameraPosition.position;
                        MainCamera.rotation = FightCameraPosition.rotation;
                        scrollbar1.gameObject.SetActive(true);
                        scrollbar2.gameObject.SetActive(true);
                        FightPosition.transform.position = playerMove.grid[i].transform.position;
                    }
                    // playerMove.PlayerOne.transform.position = FightPosition1.transform.position;
                    //  playerMove.PlayerTwo.transform.position = FightPosition2.transform.position;
                }

            }
        }
        /*
        if (PlayerOneStop & PlayerTwoStop)
        {
            if(Score1 < Score2)
            {
                playerMove.PlayerTwoValue = 0;
            }else
            {
                playerMove.PlayerOneValue = 0;
            }
        }*/
        scrollbarVoid();
    }

    public void scrollbarVoid() 
    {
        randomNumberFloat = randomNumber;
        randomNumberFloat /= 10;
        ElapsedTime += Speed * Time.deltaTime;

        if (!PlayerOneStop)
        {
            scrollbar1.value = Mathf.Lerp(minimum, maximum, ElapsedTime);

            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerOneStop = true;
                Debug.Log("stop");
                Score1 = randomNumberFloat -= scrollbar1.value;
            }

            if (ElapsedTime > 1.0f)
            {
                float temp = maximum;
                maximum = minimum;
                minimum = temp;
                ElapsedTime = 0.0f;
            }
        }

        if (!PlayerTwoStop)
        {
            scrollbar2.value = Mathf.Lerp(minimum, maximum, ElapsedTime);

            if (Input.GetKeyDown(KeyCode.P))
            {
                PlayerTwoStop = true;
                Debug.Log("stop");
                Score2 = randomNumberFloat -= scrollbar2.value;
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
