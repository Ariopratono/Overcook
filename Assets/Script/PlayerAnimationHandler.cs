using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationHandler : MonoBehaviour
{
    public HoldCheck holdis; 

    Animator animator;
    // [SerializeField] private Animator kitchenObjectAnimator;

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

        if(holdis.ItemHold == true)
        {
            animator.SetBool("IsHold", true);
        }

        if(holdis.ItemHold == false)
        {
            animator.SetBool("IsHold", false);
        }

        // if(Input.GetKey("e"))
        // {
        //     animator.SetBool("IsHold", true);

        //     if(Input.GetKey("e"))
        //     {
        //         animator.SetBool("IsHold", false);
        //     }
        // }
        // if((!Input.GetKey("e"))) {
        //     animator.SetBool("IsHold",false);
        // }
    }

//     public void SetKitchenObject(KitchenObject kitchenObject)
//     {
//         // Update animator state based on whether the kitchen object is not null
//         kitchenObjectAnimator.SetBool("IsHold", kitchenObject != null);

//         if (kitchenObject != null)
//         {
//             Debug.Log("Started holding an object.");
//         }
//         else
//         {
//             Debug.Log("Stopped holding an object.");
//         }
//     }  

}
