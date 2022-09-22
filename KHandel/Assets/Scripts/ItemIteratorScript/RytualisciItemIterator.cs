using System;
using System.Collections.Generic;

public class RytualisciItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isRytualista)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
