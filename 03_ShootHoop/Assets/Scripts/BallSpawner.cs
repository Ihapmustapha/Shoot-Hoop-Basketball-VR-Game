using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    public GameObject ballPrefab; //creating a public gameObject then drag and drop the reference 3d model from unity editor

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
         

        //Getting Different keys will through the ball in different directions back, forward, left and right
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            generateRandomBall(Vector3.forward);

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            generateRandomBall(Vector3.back);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            generateRandomBall(Vector3.right);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            generateRandomBall(Vector3.left);

        }
    }

    private void generateRandomBall(Vector3 Direction)
    {
        GameObject instance = Instantiate(ballPrefab);   //Create a New Game Object by the reference ballPreFab
        Rigidbody rd = instance.GetComponent<Rigidbody>(); //Accessing the component Rigidbody of 'instance' 
        rd.velocity = Direction * 5.0f;                       //from Rigidbody Access the function Velocity and change it
    }
}
