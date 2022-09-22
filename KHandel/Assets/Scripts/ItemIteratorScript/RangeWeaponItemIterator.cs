using System;
using System.Collections.Generic;

public class RangeWeaponItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isRangeWeapon)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
