using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCheck : MonoBehaviour
{
    public bool ItemHold; 

    // Update is called once per frame
    void Update()
    {
        if(this.transform.childCount > 0)
        {
            ItemHold = true; 
        }
        
        if(this.transform.childCount <= 0)
        {
            ItemHold = false;
        }
    }
}
