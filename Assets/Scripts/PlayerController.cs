using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move vehicle forward
        // transform.Translate(0,0,1); -- inefficient
        //transform method of the vehicle object this is attached to is then translated
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //the part that is * Time allows updates per second vs per frame;
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            //we want to affect Y-rotation in our code
            // .up refers to Y-axis, so we are rotating around that in this line
    }

}
