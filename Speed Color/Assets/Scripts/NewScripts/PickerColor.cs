using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickerColor : MonoBehaviour
{
    public GUIText scoreText;

    public int score;

    public float timeLeft = 7.0f;

    public GameObject[] difAnswers;

    public GameObject activeAnswer;

    public Button playerClick;

    public GameObject[] difColorsDif1;

    public GameObject[] difColorsDif2;

    public GameObject[] activeAnswer2;

    private int difficulty;

    void Start()
    {

        activePrefab = (GameObject)Instantiate(difColorsDif1[Random.Range(0, difColorsDif1.Length)], transform.position, transform.rotation);
        activeAnswer = (GameObject)Instantiate(difAnswers[0], new Vector3(0, 0, -3), transform.rotation);

        difficulty = 0;
    }


    public static void ShuffleArray<T>(T[] arr)
    {
        for (int i = arr.Length - 1; i > 0; i--)
        {
            int r = Random.Range(0, i + 1);
            T tmp = arr[i];
            arr[i] = arr[r];
            arr[r] = tmp;
        }
    }

    void Update()
    {

        timeLeft = timeLeft - Time.deltaTime;

        if (timeLeft < 0)
        {
            Application.LoadLevel("GameOver");
            Debug.Log("Triggered");
        }

  

    }



    void onEnable()
    {
        playerClick.onClick.AddListener(playerhasClickedRight);
    }


    public GameObject activePrefab;

    public int y = 0;

    public void playerhasClickedRight()
    {





        if (activePrefab != null)
        {
            Destroy(activePrefab);

        }
        y++;



        Debug.Log("Clicked");
        if (difficulty < 5)
        {
            if (y == 4)
            {
                y = 0;
            }

            Debug.Log(y);
            activePrefab = (GameObject)Instantiate(difColorsDif1[y], transform.position, transform.rotation);
        }
        else if (difficulty >= 5)
        {
            if (y == 8)
            {
                y = 0;
            }

            activePrefab = (GameObject)Instantiate(difColorsDif2[y], transform.position, transform.rotation);
        }





    }

    public void playerhasClickedLeft()
    {





        if (activePrefab != null)
        {
            Destroy(activePrefab);

        }

        y--;
        Debug.Log("Clicked");
        if (difficulty < 5)
        {
            if (y == -1)
            {
                y = 3;
            }

            Debug.Log(y);
            activePrefab = (GameObject)Instantiate(difColorsDif1[y], transform.position, transform.rotation);
        }
        else if (difficulty >= 5)
        {
            if (y == -1)
            {
                y = 7;
            }

            activePrefab = (GameObject)Instantiate(difColorsDif2[y], transform.position, transform.rotation);
        }



    }



    public void answerChecker()
    {
        if (activePrefab.tag == activeAnswer.tag)
        {
            if (difficulty < 5)
            {




                ShuffleArray(difColorsDif1);
                if (activePrefab != null)
                {
                    Destroy(activePrefab);

                }

                if (activeAnswer != null)
                {
                    Destroy(activeAnswer);

                }


                activePrefab = (GameObject)Instantiate(difColorsDif1[Random.Range(0, difColorsDif1.Length)], transform.position, transform.rotation);

                activeAnswer = (GameObject)Instantiate(difAnswers[Random.Range(0, difColorsDif1.Length)], new Vector3(0, 0, -3), transform.rotation);



                GameObject.Find("Slider").GetComponent<Timer>().Slider.fillAmount = 1f;

                GameObject.Find("ScoreText").GetComponent<ScoreController>().score++;

                difficulty++;

                timeLeft = 7;
            }

            if (difficulty >= 5)
            {
                ShuffleArray(difColorsDif2);
                if (activePrefab != null)
                {
                    Destroy(activePrefab);

                }

                if (activeAnswer != null)
                {
                    Destroy(activeAnswer);

                }


                activePrefab = (GameObject)Instantiate(difColorsDif2[Random.Range(0, difColorsDif2.Length)], transform.position, transform.rotation);

                activeAnswer = (GameObject)Instantiate(activeAnswer2[Random.Range(0, difColorsDif2.Length)], new Vector3(0, 0, -3), transform.rotation);



                GameObject.Find("Slider").GetComponent<Timer>().Slider.fillAmount = 1f;

                GameObject.Find("ScoreText").GetComponent<ScoreController>().score++;

                difficulty++;

                timeLeft = 7;
            }
        }
        

    }
}
