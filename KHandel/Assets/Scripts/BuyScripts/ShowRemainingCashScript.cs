using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRemainingCashScript : MonoBehaviour
{
    private void OnEnable()
    {
        ShoppingEventSystem.sendNewCashAmount += ShowHowMuchCashLeft;
    }
    private void OnDisable()
    {
        ShoppingEventSystem.sendNewCashAmount -= ShowHowMuchCashLeft;
    }

    public void ShowHowMuchCashLeft(float cash)
    {
        gameObject.GetComponent<Text>().text = cash.ToString();
    }

}
