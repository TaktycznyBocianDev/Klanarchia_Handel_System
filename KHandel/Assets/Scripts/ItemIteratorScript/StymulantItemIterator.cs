using System;
using System.Collections.Generic;

public class StymulantItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isStymulant)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
