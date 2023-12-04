using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    float moveForward;
    float moveSide;
    public float speed = 5f;
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveForward = Input.GetAxis("Vertical");
        moveSide = Input.GetAxis("Horizontal");

        rb.velocity = 
            transform.forward * moveForward * speed + 
            transform.right * moveSide * speed;

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z);
    }

}
