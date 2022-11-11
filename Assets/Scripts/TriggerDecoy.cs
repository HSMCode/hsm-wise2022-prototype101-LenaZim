using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
     public GameObject Roboter;
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggert into " + gameObject.name);

        if(other.name == Roboter.name)
        {
            //when roboter collides with decoy
            Debug.Log("Ouch..");
        }
    }
}
