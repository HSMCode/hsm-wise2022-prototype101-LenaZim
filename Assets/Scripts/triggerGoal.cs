using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerGoal : MonoBehaviour
{
    public GameObject Roboter;
    ParticleSystem Particles;
    public AudioClip goalSFX;
    private AudioSource _audioSource;

    public ParticleSystem playParticlesSystem;
    public ParticleSystem emitParticlesSystem;

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        Particles = GetComponent<ParticleSystem>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " triggert into " + gameObject.name);


        if(other.name == Roboter.name)
        {
            //when roboter collides with goal
            Debug.Log("Victory");
            
            //Play Particles
            EmitParticles();

            PlayParticles(true);


            //Particles.Play();

            _audioSource.PlayOneShot(goalSFX, 1f);
        }

    }


    void EmitParticles()
    {
        emitParticlesSystem.Emit(50);
    }
     
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

        playParticlesSystem.Play();
        playParticlesSystem.Stop();
    }
}
