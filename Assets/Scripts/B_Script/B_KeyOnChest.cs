using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_KeyOnChest : MonoBehaviour
{
    [SerializeField] GameObject item;

    public void ChestOpen()
    {
        item.SetActive(true);
    }
}
