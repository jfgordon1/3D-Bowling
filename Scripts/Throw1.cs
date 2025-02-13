using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw1 : MonoBehaviour
{
    public float speed = 0f;
    public float velocity;
    Rigidbody rb;
    public float torque = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //INCREASES THE POWER OF THE BALL
        if(Input.GetKeyDown(KeyCode.UpArrow)){
        speed = speed + 1000f;
        //Console.WriteLine(speed);
        if(speed >= 10000f){
            speed = 10000f;
        }
       }

       //DECREASES THE POWER OF THE BALL
       if(Input.GetKeyDown(KeyCode.DownArrow)){
        speed = speed - 1000f;
        //Console.WriteLine(speed);
        if(speed<0f){
            speed = 0f;
        }
       }
        //ADDS ROTATION
       if(Input.GetKeyDown(KeyCode.A)){
            torque = torque - 20;
        }

        //ADDS ROTATION
        if(Input.GetKeyDown(KeyCode.D)){
            torque = torque + 20; 
        }

       //THROWS THE BALL
       if(Input.GetKeyDown(KeyCode.Space)){
            velocity = speed;
            gameObject.GetComponent<Rigidbody>().AddForce(0f, 0f, velocity);
            rb.AddTorque(torque, 0, 0, ForceMode.Impulse);
       }
    }
}
