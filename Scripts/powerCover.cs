using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerCover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.Translate(0f,  27.3f, 0f);
            if(transform.position.y > -273.3f){
                transform.Translate(0f, -273.3f, 0f);
            }
        }

        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.Translate(0f,  -27.3f, 0f);
            if(transform.position.y < -472.4f){
                transform.Translate(0f,  -472.4f, 0f);
            }
        }
    }
}
