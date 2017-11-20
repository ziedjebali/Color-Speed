using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {


    public Text scoreFinal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        scoreFinal.text = "" + GameObject.Find("ScoreText").GetComponent<ScoreController>().score;
    }
}
