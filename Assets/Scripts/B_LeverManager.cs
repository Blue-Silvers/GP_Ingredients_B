using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_LeverManager : MonoBehaviour
{
    [Header("Levers")]
    [SerializeField] Animator lever1; //use for secret room
    [SerializeField] Animator lever2; //use for coffin
    [SerializeField] Animator lever3; //use for coffin
    [SerializeField] Animator lever4; 
    [SerializeField] Animator lever5; //use for coffin
    [SerializeField] Animator lever6; //use for secret room
    [SerializeField] Animator lever7; 
    [SerializeField] Animator lever8; //use for secret room
    [SerializeField] Animator lever9; //use for secret room
    [Header("Doors")]
    [SerializeField] Animator coffin; 
    [SerializeField] Animator secretDoor;


    void Update()
    {
        if (lever1.GetBool("On") == false && lever8.GetBool("On") == false && lever6.GetBool("On") == false && lever9.GetBool("On") == false) 
        {
            if (lever2.GetBool("On") == true && lever3.GetBool("On") == true && lever4.GetBool("On") == true && lever5.GetBool("On") == true && lever7.GetBool("On") == true)
            {
                coffin.SetBool("Open", true);
            }
            else
            {
                coffin.SetBool("Open", false);
            }
        }
        else
        {
            coffin.SetBool("Open", false);
        }

        if (lever3.GetBool("On") == false && lever2.GetBool("On") == false && lever5.GetBool("On") == false)
        {
            if (lever1.GetBool("On") == true && lever8.GetBool("On") == true && lever4.GetBool("On") == true && lever6.GetBool("On") == true && lever7.GetBool("On") == true && lever9.GetBool("On") == true)
            {
                secretDoor.SetBool("Open", true);
            }
            else
            {
                secretDoor.SetBool("Open", false);
            }
        }
        else
        {
            secretDoor.SetBool("Open", false);
        }
    }
}
