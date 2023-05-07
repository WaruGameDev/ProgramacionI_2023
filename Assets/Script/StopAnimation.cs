using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    public Animator animator;
    public void SetDance()
    {
        animator.SetBool("Dance", false);
    }
}
