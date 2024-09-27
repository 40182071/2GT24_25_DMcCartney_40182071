using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //creates a varible of player inputs (unity > edit > project settings > input management)
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward
        //transform.Translate(0,0,1);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //move left and right
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        //rotates the car rather than slide it left and right
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
