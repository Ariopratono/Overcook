using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    Animator animator;  

    void Start()
    {
        animator = GetComponent<Animator>(); 
    }

    
    void Update()
    {
        if(Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        {
            animator.SetBool("IsWalking", true);
        }

        if(!(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")))
        {
            animator.SetBool("IsWalking", false);
        }

        if(Input.GetKey("e"))
        {
            animator.SetBool("IsHold", true);

            // if(Input.GetKey("e"))
            // {
            //     animator.SetBool("IsHold", false);
            // }
        }
        // if((!Input.GetKey("e"))) {
        //     animator.SetBool("IsHold",false);
        // }
    }
}
