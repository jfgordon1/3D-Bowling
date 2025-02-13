using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRigt : MonoBehaviour
{
    Rigidbody rb;
    public float xVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //gets the position of the object
      xVal= transform.position.x;

      //moves object to the left by 0.5 units
      if(Input.GetKeyDown(KeyCode.LeftArrow)){
        transform.Translate(-0.05f, 0f, 0f);
      }

      //moves the object to the right by 0.5 units
      if(Input.GetKeyDown(KeyCode.RightArrow)){
        transform.Translate(0.05f, 0f, 0f);
      }
    }
}
