using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject DineDasher;
    public GameObject ProperCustomer; 
    private int CustomerSum;  

    public int xPos; 
    public int zPos; 
    public int RadNum;  

    public void Start()
    {
        StartCoroutine(SpawnCustomer());
    }

    private IEnumerator SpawnCustomer()
    {
        while(CustomerSum <= 10)
        {
            RadNum = Random.Range(1, 20); 
            xPos = Random.Range(6, 10); 
            zPos = Random.Range(-14, -9);
            if(RadNum % 2 == 0)
            {
                Instantiate(DineDasher, new Vector3 (xPos, 1, zPos), Quaternion.identity);
            } 
            else Instantiate(ProperCustomer, new Vector3 (xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(20); 
            CustomerSum += 1; 
        }
    }
}