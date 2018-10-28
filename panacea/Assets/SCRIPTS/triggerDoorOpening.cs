using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDoorOpening : MonoBehaviour
{
	public Animator DoorAnimator;
	public bool isOpening;
    AudioSource doorwoosh;

	void Start ()
	{
        AudioSource[] allMyAudioSources = Camera.main.gameObject.GetComponents<AudioSource>();
        doorwoosh = allMyAudioSources[0];

        DoorAnimator = gameObject.GetComponent<Animator>();
		isOpening = false;
	}
	
	public void OnTriggerEnter()
	{
		isOpening = true;

		if (isOpening == true)
		{
			DoorAnimator.SetBool("isTriggered", true);
            Invoke("DoorWooshInvoke", 0.3f);
          
		}
	}

	public void OnTriggerExit()
	{
		isOpening = false;

		if(isOpening == false)
		{
			DoorAnimator.SetBool("isTriggered", false);
		}
	}

    public void DoorWooshInvoke()
    {
        doorwoosh.Play();
    }

	void Update ()
	{
		
	}
}

       
