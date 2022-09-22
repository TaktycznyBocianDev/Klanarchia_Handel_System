using System;

public class HerbsItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isHerbs)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}