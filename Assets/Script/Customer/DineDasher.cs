using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineDasher : MonoBehaviour
{
    [SerializeField] private GameObject BonkedAnimation; 
    public Money kaching;

    public void Start()
    {
        //kaching = GetComponent<Money>; 
    } 

    void OnMouseDown()
    {
        Destroy(obj: Instantiate(original: BonkedAnimation, position: transform.position, rotation: Quaternion.identity), t: 5f);
        Destroy(gameObject);

        kaching.AddFunds(50); 
    }
}