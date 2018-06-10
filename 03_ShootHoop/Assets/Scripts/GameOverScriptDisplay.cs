using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScriptDisplay : MonoBehaviour
{
    ScoreAbsorber ScoreAbsorber;
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        ScoreAbsorber = FindObjectOfType<ScoreAbsorber>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text =  "" + ScoreAbsorber.score;
    }
}
