using System;

public class EuforicItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isEuforic)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
