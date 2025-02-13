using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPin : MonoBehaviour
{
    Rigidbody rb;
     Vector3 pos;

     int count = 0;

     bool upRight;

    GameObject pin;

    GameObject BowlingBall;

    Vector3 newPos;

    float time;

    Collision other;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //pin = GetComponent<GameObject>();
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        newPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        upRight = true;
        
        
            if(count == 10000){
            
            Debug.Log(newPos);
            Debug.Log(count);
            Debug.Log(upRight);
            
            if(pos != newPos || transform.position.y <= -8){
                upRight = false;
                Debug.Log(upRight);
                }    
            
            if(upRight == false){
                Destroy(gameObject);
            }

            count = 0;
            }
        Debug.Log(count);
        count = count + 1;
         
          
    }
}
        


