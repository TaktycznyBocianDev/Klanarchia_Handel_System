using System;
using System.Collections.Generic;
using UnityEngine;

public interface IItemIterator
{
    public abstract List<ItemTemplate> IterateTroughtItems(ItemTemplate[] allItems);

}
