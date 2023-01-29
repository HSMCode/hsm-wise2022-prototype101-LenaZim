using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGoal : MonoBehaviour
{
    public GameObject Roboter;

    public AudioClip goalSFX;
    private AudioSource _audioSource;

    public ParticleSystem playParticlesSystem;
    public ParticleSystem emitParticlesSystem;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggert into " + gameObject.name);


        //when roboter collides with goal
        if(other.name == Roboter.name)
        {
          
            Debug.Log("Victory");
            
            //Using a ParticleSystem for emission
            EmitParticles();

            //Using a ParticleSystem with Play and Stop
            PlayParticles(true);

            _audioSource.PlayOneShot(goalSFX, 1f);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + " triggered into " + gameObject.name);

        // when roboter collides with goal
        if(other.name == Roboter.name)
        {
            Debug.Log("Exit");
            
            // Using a ParticleSystem with Play and Stop - play false
            PlayParticles(false);
        }

    }

    //execute emitting of particles
    void EmitParticles()
    {
        emitParticlesSystem.Emit(50);
    }
     
    //execute playing of particles
    void PlayParticles(bool on)
    {

        if(on)
        {
            playParticlesSystem.Play();
        }
        else if(!on)
        {
            playParticlesSystem.Stop();
        }

    }
}
