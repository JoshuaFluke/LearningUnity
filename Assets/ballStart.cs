using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballStart : MonoBehaviour {
    public GameObject ball;
    // Use this for initialization
    void Start () {


        Vector3 startPosition = new Vector3(9,30,-1);
        transform.position = startPosition; //on start go to the new position
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
