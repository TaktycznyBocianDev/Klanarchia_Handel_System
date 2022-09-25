using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashInputScript : MonoBehaviour
{
    [SerializeField] InputField cashInputField;
    [SerializeField] GameObject errorText;

    public void GetCashAmount(string startingCash)
    {
        bool isParsable = float.TryParse(startingCash, out float startingCashFloat);

        if (isParsable)
        {
            errorText.SetActive(false);
            cashInputField.GetComponent<Image>().color = Color.green;
            ShoppingEventSystem.SendNewCashAmount(startingCashFloat);
        }
        else
        {
            cashInputField.text = "";
            cashInputField.GetComponent<Image>().color = Color.red;
            errorText.SetActive(true);
        }
    }
}
