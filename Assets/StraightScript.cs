using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightScript : MonoBehaviour
{
    private Rigidbody rb;
    //private float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0.1f, 0);

    }

    // Update is called once per frame
    /*void FixedUpdate()
    {
        if (rb.velocity.magnitude < 10)
        {
            
            float currentSpeed = speed - rb.velocity.magnitude;
            
            rb.AddForce(new Vector3(0, currentSpeed, 0));
            
        }
    }*/
}
