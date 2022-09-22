using System;
using System.Collections.Generic;

public class EuforicItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isEuforic)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
