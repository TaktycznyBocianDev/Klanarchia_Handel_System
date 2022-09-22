using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlaceHolderBehaviour : MonoBehaviour
{
    [SerializeField] ItemTemplate template;
    [SerializeField] Text itemName, itemDescription, itemPrice;

    private void OnEnable()
    {
        itemName.text = template.itemName;
        itemDescription.text = template.itemDescription;
        itemPrice.text = "Koszt: \n" + template.itemPrice.ToString();
    }
}
