using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCursor : MonoBehaviour {
    public bool lockCursor = true;
    AudioSource invsound;

    // Use this for initialization
    void Start () {
        // Cursor.visible = false;
        AudioSource[] allMyAudioSources = Camera.main.gameObject.GetComponents<AudioSource>();
        invsound = allMyAudioSources[3];
    }
   
   

    void Update()
    {

        // pressing esc toggles between hide/show
        if (Input.GetKeyDown(KeyCode.I))
        {
            lockCursor = !lockCursor;
            invsound.Play();
        }

        Cursor.lockState = lockCursor ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockCursor;
    }
}

    

