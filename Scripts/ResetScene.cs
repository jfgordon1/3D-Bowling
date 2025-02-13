using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetScene : MonoBehaviour
{
    private ResetBall resetBall;
    // Start is called before the first frame update
    void Start()
    {
      //resetBall =   
    }

    // Update is called once per frame
    void Update()
    {
        int count =0;
        if(resetBall.turnCount == 2 || Input.GetKeyDown(KeyCode.R)){
            if(count == 200){
            SceneManager.LoadScene("SampleScene");
            }
            else{
                count++;
            }
        }
    }
}
