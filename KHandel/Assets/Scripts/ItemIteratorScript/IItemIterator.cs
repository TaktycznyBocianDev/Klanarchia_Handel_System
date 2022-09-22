using System;
using UnityEngine;

public interface IItemIterator
{
    public abstract ItemTemplate[] IterateTrueItems(ItemTemplate[] allItems);

}
