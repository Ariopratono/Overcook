using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperCustomer : MonoBehaviour
{
    [SerializeField] private GameObject Crueled; 
    public Money kaching; 

    void OnMouseDown()
    {
        Destroy(obj: Instantiate(original: Crueled, position: transform.position, rotation: Quaternion.identity), t: 5f);
        Destroy(gameObject);

        kaching.SubstractFunds(50); 
    }
}
