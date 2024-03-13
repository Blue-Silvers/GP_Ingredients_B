using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_SecretLight : MonoBehaviour
{
    [SerializeField] GameObject fire1;
    bool torchOnFire1 = false;
    [SerializeField] GameObject fire2;
    bool torchOnFire2 = false;
    [SerializeField] GameObject fire3;
    bool torchOnFire3 = false;
    [SerializeField] GameObject fire4;
    bool torchOnFire4 = false;
    [SerializeField] GameObject RedLight;

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
        if (fire4.activeSelf == true)
        {
            torchOnFire4 = true;
        }
        if (torchOnFire1 == true && torchOnFire2 == true && torchOnFire3 == true && torchOnFire4 == true)
        {
            RedLight.SetActive(true);
            fire1.transform.GetChild(0).gameObject.SetActive(false);
            fire1.transform.GetChild(1).gameObject.SetActive(false);
            fire2.transform.GetChild(0).gameObject.SetActive(false);
            fire2.transform.GetChild(1).gameObject.SetActive(false);
            fire3.transform.GetChild(0).gameObject.SetActive(false);
            fire3.transform.GetChild(1).gameObject.SetActive(false);
            fire4.transform.GetChild(0).gameObject.SetActive(false);
            fire4.transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
