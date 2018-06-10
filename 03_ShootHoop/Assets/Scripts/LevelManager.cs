using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public float timeTilNextLevel = 30.0f; 

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
        

        timeTilNextLevel -= Time.deltaTime;
        
        
        
            if (timeTilNextLevel < 0)
            {
                LoadNextScene();
            }
        
     }

    public void LoadNextScene()
    {
        //load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Load Current Index +1 
        SceneManager.LoadScene(currentIndex + 1);
    }

    public void LoadPreviousScene()
    {
        //Load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Load Current Index -1
        SceneManager.LoadScene(currentIndex - 1); 

    }
}
