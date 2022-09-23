using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPlaceHolderBehaviour : MonoBehaviour
{
    public ItemTemplate template;
    [SerializeField] Text itemName, itemDescription, itemPrice;
    [SerializeField] Image itemImage;

    private void OnEnable()
    {
        itemImage.sprite = template.itemImage;
        itemName.text = template.itemName;
        itemDescription.text = template.itemDescription;
        itemPrice.text = "Koszt: \n" + template.itemPrice.ToString();
    }
}
