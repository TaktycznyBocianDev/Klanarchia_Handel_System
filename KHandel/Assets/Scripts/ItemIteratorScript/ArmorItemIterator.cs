using System;

public class ArmorItemIterator
{
    ItemTemplate[] specificItems;

    public ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems)
    {
        int i = 0;

        foreach (var item in allItems)
        {
            if (item.isArmor)
            {
                specificItems[i] = item;
                i++;
            }
        }
        return specificItems;
    }
}
