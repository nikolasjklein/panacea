using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInventoryHandler : MonoBehaviour
{
    public GameObject AudioCanvas;
    public GameObject AudioLogBox;
    private bool isActive;
    public float delay = 1.0f;

    void Start()
    {
        AudioCanvas.SetActive(true);
        AudioLogBox.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            isActive = !isActive;
            AudioCanvas.SetActive(isActive);
            AudioLogBox.SetActive(isActive);
        }
    }
}