using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    private Rigidbody _rigidbody;

    private float jumpForce = 10;
    private bool jump = false;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        transform.Translate(Input.acceleration.x, 0, 0);
    }

    void Jump()
    {
        if(Input.acceleration.z <= -1 && !jump)
        {
            //transform.Translate(0, 0.2f * jumpForce, 0);
            _rigidbody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            jump = true;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground")
        {
            jump = false;
        }
    }
}
