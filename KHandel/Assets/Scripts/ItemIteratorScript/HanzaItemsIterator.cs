using System;
using UnityEngine;

public class HanzaItemsIterator : IItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isHanza)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}