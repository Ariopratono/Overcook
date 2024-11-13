using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    public GameObject charStanding; 
    public GameObject charSitting; 
    public bool sittable; 
    public bool sitted; 

    void OnTriggerEnter(Collider target)
    {
        if(target.CompareTag("Customer"))
        {
            sittable = true; 
        }
    }

    void OnTriggerExit(Collider target)
    {
        if(target.CompareTag("Customer"))
        {
            sittable = false;
        }
    }

    void Update()
    {
        if(sittable == true)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                charSitting.SetActive(true);
                sitted = true;
                charStanding.SetActive(false);
                sittable = false;
            } 
        }

        if(sitted == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                charSitting.SetActive(false);
                charStanding.SetActive(true);
                sitted = false;
            } 
        }
    }
}