using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingSystemManager : MonoBehaviour
{
    [SerializeField] GameObject notCashEnoughtTxt;
    private float cashAmount;

    private void OnEnable()
    {
        ShoppingEventSystem.sendNewCashAmount += SetStartingCashAmount;
        ShoppingEventSystem.userBuy += DoShopping;
    }
    private void OnDisable()
    {
        ShoppingEventSystem.sendNewCashAmount -= SetStartingCashAmount;
        ShoppingEventSystem.userBuy -= DoShopping;
    }

    private void SetStartingCashAmount(float startingCash)
    {
        cashAmount = startingCash;
    }

    private void DoShopping(float currentItemPrice)
    {
        if(cashAmount > currentItemPrice)
        {
            notCashEnoughtTxt.SetActive(false);
            cashAmount -= currentItemPrice;
            ShoppingEventSystem.SendNewCashAmount(cashAmount);
        }
        else
        {
            notCashEnoughtTxt.SetActive(true);
        }
    }



}
