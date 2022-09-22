using System;

public class StymulantItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isStymulant)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
