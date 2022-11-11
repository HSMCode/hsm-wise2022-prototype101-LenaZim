using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDecoy : MonoBehaviour
{
    public GameObject Roboter;
    public AudioClip decoySFX;
    private AudioSource _audioSource;

    void Start ()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggert into " + gameObject.name);

        if(other.name == Roboter.name)
        {
            //when roboter collides with decoy
            Debug.Log("Ouch..");

            _audioSource.PlayOneShot(decoySFX, 1f);

            Destroy(gameObject,1f);
        }
    }
}
