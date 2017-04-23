using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        print("hi");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision ball)
    {
        print("detect");
        ball.rigidbody.AddRelativeForce(transform.forward * 1000);
    }
}