using System;
using System.Collections.Generic;
using UnityEngine;

public class HanzaItemsIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isHanza)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}