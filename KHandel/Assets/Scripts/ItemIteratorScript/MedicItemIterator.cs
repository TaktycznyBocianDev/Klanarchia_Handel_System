using System;

public class MedicItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isMedic)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
