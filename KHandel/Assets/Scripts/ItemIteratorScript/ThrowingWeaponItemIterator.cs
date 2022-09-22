using System;
using System.Collections.Generic;

public class ThrowingWeaponItemIterator : IItemIterator
{
    public List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems)
    {
        List<ItemTemplate> tmpItemsArray = new List<ItemTemplate>();
        foreach (var item in allItems)
        {
            if (item.isThrowingWeapon)
            {
                tmpItemsArray.Add(item);
            }
        }
        return tmpItemsArray;
    }
}
