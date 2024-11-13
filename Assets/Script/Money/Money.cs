using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public int funds; 

    public TMP_Text textFunds; 

    public void Start()
    {
        funds = 0; 

        textFunds.text = funds.ToString(); 
    }

    public void AddFunds(int fund)
    {
        funds = funds + fund; 

        textFunds.SetText(funds.ToString());
    }

    public void SubstractFunds(int fund)
    {
        funds = funds - fund; 

        textFunds.SetText(funds.ToString()); 
    }
}