using System;

public class TechnologicalEqItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isTechnologicalEq)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}