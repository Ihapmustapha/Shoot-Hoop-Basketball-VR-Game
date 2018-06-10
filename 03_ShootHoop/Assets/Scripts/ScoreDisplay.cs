using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
    ScoreKeeper ScoreKeeper;
    Text text; 
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        ScoreKeeper = FindObjectOfType<ScoreKeeper>(); 
	}
	
	// Update is called once per frame
	void Update () {    
        text.text = "Score: " + ScoreKeeper.Score ; 
	}
}
