using System;
using System.Collections.Generic;
using UnityEngine;

public class TabBehaviour : MonoBehaviour
{
    [Header("Place here all itemHolders")]
    [SerializeField] GameObject[] objects;

    [Header("There should be placed rectTransform of grid's panel")]
    [SerializeField] RectTransform rectTransformOfGrid;


    [Header("In every new tab should be defined which type of item it will take for sale")]
    public TabTypes tabType;

    public void DealWithItems(List<ItemTemplate> items)
    {
        PlaceItemsInFolders(items);
        SetPanelOfItemOnCorrectSize(items.Count);
        SetActiveItemsPlaces(items.Count);
    }

    public void PlaceItemsInFolders(List<ItemTemplate> items)
    {
        for (int i = 0; i < items.Count; i++)
        {
            objects[i].GetComponent<ItemPlaceHolderBehaviour>().template = items[i];
        }
    }

    public void SetActiveItemsPlaces(int howMany)
    {
        for (int i = 0; i < howMany; i++)
        {
            objects[i].SetActive(true);
        }
    }

    public void SetPanelOfItemOnCorrectSize(int howMany)
    {
        int startingSize = -333;
        int tmp = -400;

        tmp = tmp * howMany;

        int finalSize = startingSize + tmp;

        RectTransformExtensions.SetBottom(rectTransformOfGrid, finalSize);
    }




}
