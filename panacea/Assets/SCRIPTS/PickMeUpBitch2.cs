using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMeUpBitch2 : MonoBehaviour
{
	public SoundFile item;
	private AudioInventory audioInventory;

	public void Start()
	{
		audioInventory = FindObjectOfType<AudioInventory>();
	}

	public void OnTriggerEnter()
	{
		audioInventory.AddItem(item);
		Destroy(gameObject);
	}
}
