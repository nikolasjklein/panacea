using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListButton : MonoBehaviour
{
	[SerializeField]
	private Text myText;

    public AudioClip SoundClip;
    public AudioSource SoundSource;

    public void Start()
    {
        SoundSource.clip = SoundClip;
    }

    public void SetText(string textString)
	{
        //myText.text = //textfromthescriptableobject
	}

	public void ClickMeBitch()
	{
        SoundSource.Play();
	}
}
