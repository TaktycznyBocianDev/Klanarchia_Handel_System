using System;
using System.Collections.Generic;

public class MedicItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isMedic)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
