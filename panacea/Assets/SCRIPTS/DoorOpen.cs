using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public AudioClip SoundClip;
    public AudioSource SoundSource;

    // Use this for initialization
    void Start ()
    {
        SoundSource.clip = SoundClip;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        SoundSource.Play();
    }
}
