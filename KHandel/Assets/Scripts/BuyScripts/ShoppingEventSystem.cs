using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingEventSystem
{

    public delegate void CashAmountHaveHange(float cashAmount);
    public static event CashAmountHaveHange sendNewCashAmount;

    public static void SendNewCashAmount(float cashAmount)
    {
        sendNewCashAmount?.Invoke(cashAmount);
    }

    public delegate void UserBuySomething(float cashAmount);
    public static event UserBuySomething userBuy;

    public static void UserBuy(float price)
    {
        userBuy?.Invoke(price);
    }

}
