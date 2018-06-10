using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TimeDisplay : MonoBehaviour {
    LevelManager Timer;
    Text Text;
    
	// Use this for initialization
	void Start () {
        Timer = FindObjectOfType<LevelManager>();
        Text = GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update () {
        Text.text = "Time Remaining: " + Timer.timeTilNextLevel; 
	}
}
