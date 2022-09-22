﻿using System;

public class ThrowingWeaponItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isThrowingWeapon)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}