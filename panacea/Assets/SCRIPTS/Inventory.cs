using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
	public Image[] itemImages = new Image[numItemSlots];
	public Item[] items = new Item[numItemSlots];

	//DEBUG STUFF
	public Text slotText;
	public Text maskText;
	public Text itemText0;
	public Text itemText1;
	public Text itemText2;
	public Text itemText3;
	public Text itemText4;

	/*/
	public AudioClip[] audioClips; //All Audio clips you want to be playable here
	public bool examiningObject;
	public GameObject myPickUpObjectScript,ExaminedObject,player,camera;
	public Mesh[] ExaminedObjectModels;
	public AudioSource myAudioSource;
	*/

	public GameObject PollutionCube; 

	public const int numItemSlots = 5;

		public int curCheck; //The Slot to Check
		private float coolDown;
		public bool isMasked;


void Update()
{
	//MASK TEXT
		if (PollutionCube.GetComponent<SporeDeath>().isMasked)
		{
			maskText.GetComponent<Text>().text = "<color=red>HIGH</color>";
		}
		else
		{
			maskText.GetComponent<Text>().text = "<color=green>LOW</color>";
        }

	//PRINT OUT ALL THE SLOTS WITH ITS ITEMS IN THEM
		if (items[0] != null)
		{
			itemText0.GetComponent<Text>().text = items[0].ToString();
		}
		else
		{
			itemText0.GetComponent<Text>().text = "";
		}

		if (items[1] != null)
		{
			itemText1.GetComponent<Text>().text = items[1].ToString();
		}
		else
		{
			itemText1.GetComponent<Text>().text = "";
		}

		if (items[2] != null)
		{
			itemText2.GetComponent<Text>().text = items[2].ToString();
		}
		else
		{
			itemText2.GetComponent<Text>().text = "";
		}

		if (items[3] != null)
		{
			itemText3.GetComponent<Text>().text = items[3].ToString();
		}
		else
		{
			itemText3.GetComponent<Text>().text = "";
		}

		if (items[4] != null)
		{
			itemText4.GetComponent<Text>().text = items[4].ToString();
		}
		else
		{
			itemText4.GetComponent<Text>().text = "";
		}

		//TEXT COLORING
		if (curCheck == 0)
		{
			itemText0.color = new Color(40.0f/255.0f, 164.0f/255.0f, 241.0f/255.0f);
		}
		else
		{
			itemText0.color = new Color(26.0f / 255.0f, 94.0f / 255.0f, 136.0f / 255.0f);
        }

		if (curCheck == 1)
		{
			itemText1.color = new Color(40.0f / 255.0f, 164.0f / 255.0f, 241.0f / 255.0f);
        }
		else
		{
			itemText1.color = new Color(26.0f / 255.0f, 94.0f / 255.0f, 136.0f / 255.0f);
        }

		if (curCheck == 2)
		{
			itemText2.color = new Color(40.0f / 255.0f, 164.0f / 255.0f, 241.0f / 255.0f);
        }
		else
		{
			itemText2.color = new Color(26.0f / 255.0f, 94.0f / 255.0f, 136.0f / 255.0f);
        }

		if (curCheck == 3)
		{
			itemText3.color = new Color(40.0f / 255.0f, 164.0f / 255.0f, 241.0f / 255.0f);
        }
		else
		{
			itemText3.color = new Color(26.0f / 255.0f, 94.0f / 255.0f, 136.0f / 255.0f);
        }

		if (curCheck == 4)
		{
			itemText4.color = new Color(40.0f / 255.0f, 164.0f / 255.0f, 241.0f / 255.0f);
        }
		else
		{
			itemText4.color = new Color(26.0f / 255.0f, 94.0f / 255.0f, 136.0f / 255.0f);
        }

		/*
		//ITEM INSPECTING
		if (examiningObject)
		{
				ExaminedObject.transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), 0, 0));
				ExaminedObject.transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0));
			
		}

		// ===========================
		// start examining

		if (Input.GetButtonDown("Fire2") && !examiningObject)
		{
				examiningObject = true;
				ExaminedObject.SetActive(true);
				myAudioSource.time = 0;
				myAudioSource.Play();
				//if you need to change the clip that is played do
				//myAudioSource.clip = audioClips[0];//Replace 0 with what clip in the array you need
				//Set the Mesh based on what is in the slot
				ExaminedObject.GetComponent<MeshFilter>().mesh = ExaminedObjectModels[0]; 
				player.GetComponent<FirstPersonDrifter>().enabled = false;
				camera.GetComponent<MouseLook>().enabled = false;
				player.GetComponent<MouseLook>().enabled = false;
				Debug.Log("Examining");
		}

		// ===========================
		// end examining

		if (Input.GetButtonUp("Fire2") && examiningObject)
		{
				examiningObject = false;
				myAudioSource.Stop();
				ExaminedObject.SetActive(false);
				player.GetComponent<FirstPersonDrifter>().enabled = true;
				player.GetComponent<MouseLook>().enabled = true;
				camera.GetComponent<MouseLook>().enabled = true;
				Debug.Log("No Longer Examining");
		}
		*/


	coolDown+=0.4f;
	if (Input.GetAxis("Mouse ScrollWheel")<=-.1 && coolDown >1)
	{
		//Scroll Up
		curCheck+=1;
		coolDown = 0;
	}
	else if (Input.GetAxis("Mouse ScrollWheel")>=.1 && coolDown >1)
	{
		//Scroll Down
		curCheck-=1;	
		coolDown = 0;
	}

	if (curCheck>4)
	{
		curCheck = 0;
	}
	else if(curCheck<0)
	{
		curCheck = 4;
	}

	if (Input.GetKeyDown(KeyCode.G))
	{
		if (items[curCheck]!= null)
		{
			Debug.Log(items[curCheck]); 
			//items[curCheck] = null;
		}
		else
		{
			Debug.Log("null value");
		}

		if (items[curCheck].name == "Mask")
		{
			PollutionCube.GetComponent<SporeDeath>().isMasked = !PollutionCube.GetComponent<SporeDeath>().isMasked;
		}
	}

}

	public void AddItem(Item itemToAdd)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if(items[i] == null)
			{
				items[i] = itemToAdd;
				itemImages[i].sprite = itemToAdd.sprite;
				itemImages[i].enabled = true;
				return;
			}
		}
	}

	public void RemoveItem(Item itemToRemove)
	{
		for (int i = 0; i < items.Length; i++)
		{
			if(items[i] == itemToRemove)
			{
				items[i] = null;
				itemImages[i].sprite = null;
				itemImages[i].enabled = true;
				return;
			}
		}
	}
}