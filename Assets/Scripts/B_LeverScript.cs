using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_LeverScript : Interactive
{
    private Animator _animator;
    private SphereCollider colliderS;
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public override void OnInteraction()
    {
        if(_animator.GetBool("On") == true)
        {
            _animator.SetBool("On", false);
        }
        else
        {
            _animator.SetBool("On", true);
        }
    }
}
