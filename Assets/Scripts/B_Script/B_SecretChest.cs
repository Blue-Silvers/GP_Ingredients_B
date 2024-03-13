using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_SecretChest : MonoBehaviour
{
    [SerializeField] GameObject fire1;
    bool torchOnFire1 = false;
    [SerializeField] GameObject fire2;
    bool torchOnFire2 = false;
    [SerializeField] GameObject fire3;
    bool torchOnFire3 = false;
    [SerializeField] GameObject chest;

    void Update()
    {
        if (fire1.activeSelf == true)
        {
            torchOnFire1 = true;
        }
        if (fire2.activeSelf == true)
        {
            torchOnFire2 = true;
        }
        if (fire3.activeSelf == true)
        {
            torchOnFire3 = true;
        }
        if(torchOnFire1 == true &&  torchOnFire2 == true && torchOnFire3 == true)
        {
            chest.SetActive(true);
        }
    }
}
