using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour
{
    public float step = 1f;
    public float turn = 90f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move robot
        if(Input.GetKeyDown("w"))
        {
            transform.Translate(0,0,step);
        }
        if(Input.GetKeyDown("s"))
        {
            transform.Translate(0,0,-step);
        }
        if(Input.GetKeyDown("d"))
        {
            transform.Translate(step,0,0);
        }
        if(Input.GetKeyDown("a"))
        {
            transform.Translate(-step,0,0);
        }

        //rotate robot
        if(Input.GetKeyDown("q"))
        {
            transform.Rotate(0,-turn,0);
        }
        if(Input.GetKeyDown("e"))
        {
            transform.Rotate(0,turn,0);
        }
    }
}
