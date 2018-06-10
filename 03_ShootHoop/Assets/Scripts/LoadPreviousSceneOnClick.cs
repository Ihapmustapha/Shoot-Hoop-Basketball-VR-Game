using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LoadPreviousSceneOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadPreviousScene()
    {
        //load Scene
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        //Load Current Index +1 
        SceneManager.LoadScene(currentIndex - 1);
    }
}
