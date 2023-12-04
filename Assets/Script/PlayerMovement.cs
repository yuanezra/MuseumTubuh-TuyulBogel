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
    void Update()
    {
        moveForward = Input.GetAxis("Vertical") * speed;
        moveSide = Input.GetAxis("Horizontal") * speed;

        rb.velocity = (transform.forward * moveForward) + (transform.right * moveSide) + (transform.up * rb.velocity.y);

    }

}
