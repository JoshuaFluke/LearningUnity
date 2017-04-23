using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {
    public GameObject cube; //created variable that will be transform
    public float speedX = 5;
    public float speedY = 5;
    public float yaw = 0;
    public float pitch = 0;
    public bool cameraMove;
    private Vector3 originalPosition;

	// Use this for initialization
	void Start () {
        originalPosition = transform.localPosition;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            //originalPosition = transform.localPosition;
            cameraMove = true;
        }
        else { cameraMove = false; }
        yaw += speedX * Input.GetAxis("Mouse X");
        pitch -= speedY * Input.GetAxis("Mouse Y");
        //transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        if (cameraMove == true)
        {
            transform.RotateAround(cube.transform.position, Vector3.up, yaw * Time.deltaTime);
            print(yaw);
            //print(pitch);
        }
        else
        {
           // transform.localPosition = originalPosition;
        }

        //x = 0 z= -4.5
    }
}
