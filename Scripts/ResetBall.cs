using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ResetBall : MonoBehaviour
{
    //Create create;
    Rigidbody rb;
    GameObject BowlingBall;
    public int turnCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float yPos = transform.position.y;
        if(yPos <=-9.14){
            rb.Sleep();
            turnCount++;
            
            transform.position = new Vector3((float) 0.09,(float) 4.889, (float) -21.21);
        }
    }
}
