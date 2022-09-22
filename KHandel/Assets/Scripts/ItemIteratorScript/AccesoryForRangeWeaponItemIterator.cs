using System;

public class AccesoryForRangeWeaponItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isAccesoryForRangeWeapon)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
