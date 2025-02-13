using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour
{
    public Vector3 starting = new Vector3((float) 0.09,(float) 4.889, (float) -21.21);
    public GameObject BowlingBall;
    // Start is called before the first frame update
    void Start()
    {
        BowlingBall = Instantiate(BowlingBall, starting, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
