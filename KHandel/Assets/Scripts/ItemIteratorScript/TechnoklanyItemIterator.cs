using System;
using UnityEngine;

public class TechnoklanyItemIterator : IItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isTechnoklan)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
