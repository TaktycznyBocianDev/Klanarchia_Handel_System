using System;

public class CloseWeaponItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isCloseWeapon)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
