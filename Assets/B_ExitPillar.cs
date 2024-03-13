using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_ExitPillar : Interactive
{
    [SerializeField] private Animator _animator;
    [SerializeField] private GameObject skull;

    public override void OnInteraction()
    {
        skull.SetActive(true);
        _animator.SetTrigger("Open");
    }
}
