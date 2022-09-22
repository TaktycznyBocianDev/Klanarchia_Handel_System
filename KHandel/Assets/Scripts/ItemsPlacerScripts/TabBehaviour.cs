using System;
using System.Collections.Generic;
using UnityEngine;

public class TabBehaviour : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    public TabTypes tabType;

    public void DealWithItems(List<ItemTemplate> items)
    {
        PlaceItemsInFolders(items);
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




}
