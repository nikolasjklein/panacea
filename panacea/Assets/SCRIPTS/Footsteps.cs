using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    AudioSource footstep;
    public float footStepDelay;
    private float nextFootstep = 0;
    CharacterController cc;

    // Use this for initialization
    void Start()
    {
        AudioSource[] allMyAudioSources = Camera.main.gameObject.GetComponents<AudioSource>();
        footstep = allMyAudioSources[2];

        cc = gameObject.GetComponentInParent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.velocity.magnitude > 3.0f)
        {
            if (!footstep.isPlaying)
            {
                footstep.Play();
            }
        }

        else
        {
            footstep.Stop();
        }

    }
}



