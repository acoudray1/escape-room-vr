using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleController : MonoBehaviour
{
    private GameObject defaultIcon, openedHandIcon;

    void Start ()
    {
        defaultIcon = GameObject.Find("ReticleIcon");
        openedHandIcon = GameObject.Find("OpenedHandIcon");

        openedHandIcon.SetActive(false);
    }

    public void ShowIcon(bool isInteraction)
    {
        defaultIcon.SetActive(!isInteraction);
        openedHandIcon.SetActive(isInteraction);
    }
}
