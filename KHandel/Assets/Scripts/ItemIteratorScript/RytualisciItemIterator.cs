using System;

public class RytualisciItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isRytualista)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
