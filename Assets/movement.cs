using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {
    //lets us edit in unity
    public int walkSpeed;
    public int sprintSpeed;
    public float dampen;
    private Rigidbody rb;
    private bool sprint;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        sprint = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift)) {
            sprint = true;
        } else { sprint = false; }
        Vector3 newPosition = new Vector3(Input.GetAxis("Horizontal")*dampen, 0, Input.GetAxis("Vertical"));
       // rb.AddForce(newPosition * 25);
        if (rb.velocity.magnitude < walkSpeed || (sprint == true && rb.velocity.magnitude <  sprintSpeed))
        { rb.AddForce(newPosition * 25); }
    }
}
