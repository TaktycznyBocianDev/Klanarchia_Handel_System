using System;

public class CustomItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isCustom)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}