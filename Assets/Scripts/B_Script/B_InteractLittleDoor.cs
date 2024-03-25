using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_InteractLittleDoor : Interactive
{

    [SerializeField] Animator secretDoor;
    
    bool open = false;
    private void Update()
    {
        if(secretDoor.GetBool("Open") == false)
        {
            open = false;
        }
    }
    public override void OnInteraction()
    {
        if (open == false)
        {
            secretDoor.SetBool("Open", true);
            open = true;
        }
        else
        {
            secretDoor.SetBool("Open", false);
            open = false;
        }
    }
}
