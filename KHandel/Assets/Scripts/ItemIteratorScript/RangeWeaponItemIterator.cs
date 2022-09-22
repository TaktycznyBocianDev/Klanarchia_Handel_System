using System;

public class RangeWeaponItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isRangeWeapon)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
