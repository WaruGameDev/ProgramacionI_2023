using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleAnimation : MonoBehaviour
{
    public Animator animator;
    private void Update()
    {      
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            animator.SetBool("Happy", !animator.GetBool("Happy"));
        }
    }
    
    
    public void Dance()
    {
        animator.SetBool("Dance", true);
    }
        
}
