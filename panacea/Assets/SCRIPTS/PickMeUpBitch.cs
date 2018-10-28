using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickMeUpBitch : MonoBehaviour
{
	public Item item;
	private Inventory inventory;

	public void Start()
	{
		inventory = FindObjectOfType<Inventory>();
	}

	public void OnTriggerEnter()
	{
		inventory.AddItem(item);
		Destroy(gameObject);
	}
}
