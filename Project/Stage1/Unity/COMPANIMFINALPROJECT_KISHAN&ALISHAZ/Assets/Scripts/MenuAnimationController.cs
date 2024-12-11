using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimationController : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        animator.Play("RedLightTimeline"); 
    }

}
