using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SporeDeath : MonoBehaviour
{

	public Text sporeText;
	public Inventory inventory;
	public GameObject PollutionCube;
	public bool isMasked;

	public void Start()
	{
		sporeText.GetComponent<Text>().text = isMasked.ToString();
	}

	public void OnTriggerEnter(Collider collider)
	{
		if (collider.tag == "Player")
		{
			if (PollutionCube.GetComponent<SporeDeath>().isMasked == true)
			{
				sporeText.GetComponent<Text>().text = "Not Dead";
			}
			else
			{
				sporeText.GetComponent<Text>().text = "Dead";
				Application.LoadLevel(Application.loadedLevel);
			}
		}
	}
}
