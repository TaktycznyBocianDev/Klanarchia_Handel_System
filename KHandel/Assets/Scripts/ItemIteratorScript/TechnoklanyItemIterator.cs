using System;
using System.Collections.Generic;
using UnityEngine;

public class TechnoklanyItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isTechnoklan)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
