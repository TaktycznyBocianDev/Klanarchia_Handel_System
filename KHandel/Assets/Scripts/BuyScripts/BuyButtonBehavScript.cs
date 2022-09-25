using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyButtonBehavScript : MonoBehaviour
{
    public void UserWantToBuy()
    {
        ItemTemplate item = gameObject.GetComponentInParent<ItemPlaceHolderBehaviour>().template;
        ShoppingEventSystem.UserBuy(item.itemPrice);
    }
}
