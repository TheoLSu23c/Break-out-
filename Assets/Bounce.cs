using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    Rigidbody myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = 4;
        myRigidbody.velocity = myRigidbody.velocity.normalized * Speed;
        if (transform.position.y < -1)
        {

        }
    }
}