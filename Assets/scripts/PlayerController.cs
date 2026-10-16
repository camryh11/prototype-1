using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; 
    public float turnSpeed = 45.0f;
    public float horizontalInput;
    public float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
          //moves the car
           transform.Translate(Vector3.forward * Time.deltaTime * 10 * forwardInput);
           //moves the car right
           transform.Rotate(Vector3.up, 50 * horizontalInput * Time.deltaTime);

    }
}
