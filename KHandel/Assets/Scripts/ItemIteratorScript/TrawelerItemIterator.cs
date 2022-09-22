using System;

public class TrawelerItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isTraweler)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
