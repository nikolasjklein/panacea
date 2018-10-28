using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioInventory : MonoBehaviour
{ 
	[SerializeField]
	private GameObject buttonTemplate;

	public SoundFile[] items = new SoundFile[numItemSlots];
	public GameObject instButton;

	public const int numItemSlots = 10;

	public void AddItem(SoundFile soundFileToAdd)
	{
		for(int i = 0; i < items.Length; i++)
		{
			if(items[i] == null)
			{
				items[i] = soundFileToAdd;
				//add button with info
					
				GameObject button = Instantiate(buttonTemplate) as GameObject;
				button.SetActive(true);

				button.GetComponent<ButtonListButton>().SetText("Button #" + i);

				button.transform.SetParent(buttonTemplate.transform.parent, false);

                //get infos from scriptable objects
                items[i].soundFile = soundFileToAdd.soundFile;
                items[i].topic = soundFileToAdd.topic;
                items[i].namedate = soundFileToAdd.namedate;


                return;
			}
		}
	}
}