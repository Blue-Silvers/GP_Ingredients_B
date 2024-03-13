using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_OpenDoorWhithKey : Interactive
{
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public override void OnInteraction()
    {
        _animator.SetTrigger("Open");

    }
}
