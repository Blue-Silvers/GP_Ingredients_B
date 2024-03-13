using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_CanvasScript : Interactive
{
    [SerializeField] private GameObject canvasImage;
    public override void OnInteraction()
    {
        if (canvasImage.activeSelf == true)
        {
            canvasImage.SetActive(false);
        }
        else
        {
            canvasImage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canvasImage.SetActive(false);
    }
}

