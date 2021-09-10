using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 30f;
    private float horizontalInput;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput <= 0 && transform.position.x > -21f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
        else if (horizontalInput >= 0 && transform.position.x < 21f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        }
    }
}
