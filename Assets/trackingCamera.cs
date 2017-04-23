using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script attached
public class trackingCamera : MonoBehaviour {
    public GameObject ball; //created variable that will be transform
	// Use this for initialization
	void Start () {
        Vector3 newPosition = new Vector3(-7, 10, -7); //new point in space
        transform.position = newPosition; //on start go to the new position
     
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(ball.transform); //camera transform look at ball transform
	}
}
