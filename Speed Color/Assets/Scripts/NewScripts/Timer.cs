using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Image Slider;            //Drag the circular image i.e Slider in our case
    public float circleTime = 7.0f;

    // Use this for initialization
    void Start()
    {
        Slider.fillAmount = 1f;      // Initally progress bar is empty
    }

    // Update is called once per frame
    void Update()
    {
        Slider.fillAmount -= Time.deltaTime / circleTime;


    }
}
