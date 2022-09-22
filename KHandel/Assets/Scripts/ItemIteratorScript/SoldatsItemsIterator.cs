using System;
using UnityEngine;

public class SoldatsItemsIterator : IItemIterator
{

    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {          
            if (item.isSoldat)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
