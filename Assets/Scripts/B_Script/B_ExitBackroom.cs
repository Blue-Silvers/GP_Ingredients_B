using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class B_ExitBackroom : MonoBehaviour
{
    [SerializeField] private GameObject exitDoor, interactCollider, tpCollider;
    Animator secretDoor;
    bool exit = false;
    Vector3 initScale;

    private void Start()
    {
        initScale = exitDoor.transform.localScale;
        secretDoor = exitDoor.GetComponent<Animator>();
    }
    private void Update()
    {
        if (exit == true)
        {
            exitDoor.transform.localScale = new Vector3(Mathf.SmoothStep(exitDoor.transform.localScale.x, initScale.x, 0.05f), Mathf.SmoothStep(exitDoor.transform.localScale.y, initScale.y, 0.05f), Mathf.SmoothStep(exitDoor.transform.localScale.z, initScale.z, 0.05f));
        }
        else
        {
            exitDoor.transform.localScale = new Vector3(Mathf.SmoothStep(exitDoor.transform.localScale.x, -0.01f, 0.05f), Mathf.SmoothStep(exitDoor.transform.localScale.y, -0.01f, 0.05f), Mathf.SmoothStep(exitDoor.transform.localScale.z, -0.01f, 0.05f));
        }
        if(exitDoor.transform.localScale.x >= 1)
        {
            interactCollider.SetActive(true);
        }
        else
        {
            interactCollider.SetActive(false);
            secretDoor.SetBool("Open", false);
        }

        if (secretDoor.GetBool("Open") == false)
        {
            tpCollider.SetActive(false);
        }
        else
        {
            tpCollider.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        exit = true;
    }
    private void OnTriggerExit(Collider other)
    {
        exit = false;
    }
}
