using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 45f;
    private float horizontlInput;
    private float verticalInput;


    void Update()
    {
        horizontlInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // turn de vehicle with slide and translate your position
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontlInput);

        // turn de vehicle with rotate
        transform.Rotate(Vector3.up, turnSpeed * horizontlInput * Time.deltaTime);
    }
}
