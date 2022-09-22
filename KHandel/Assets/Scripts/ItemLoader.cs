using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLoader : MonoBehaviour
{
    [Header("THE LIST OF ALL ITEM FOR SALE! (Do NOT put basic one here)")]
    [SerializeField] ItemTemplate[] items;

    //All tabs 
    [SerializeField] GameObject[] tabs;

    private void Start()
    {
        LoadItems();
    }

    private void LoadItems()
    {
        for (int i = 0; i < tabs.Length; i++)
        {

            TabBehaviour currentTab = tabs[i].GetComponent<TabBehaviour>();
          
            if (currentTab.tabType == TabTypes.Technoklan)
            {
                TechnoklanyItemIterator itemIterator = new TechnoklanyItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Hanza)
            {
                HanzaItemsIterator itemIterator = new HanzaItemsIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Soldat)
            {
                SoldatsItemsIterator itemIterator = new SoldatsItemsIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Rytualista)
            {
                RytualisciItemIterator itemIterator = new RytualisciItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Traweler)
            {
                TrawelerItemIterator itemIterator = new TrawelerItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.CloseWeapon)
            {
                CloseWeaponItemIterator itemIterator = new CloseWeaponItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.RangeWeapon)
            {
                RangeWeaponItemIterator itemIterator = new RangeWeaponItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.AccesoryForRangeWeapon)
            {
                AccesoryForRangeWeaponItemIterator itemIterator = new AccesoryForRangeWeaponItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.ThrowingWeapon)
            {
                ThrowingWeaponItemIterator itemIterator = new ThrowingWeaponItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Armor)
            {
                ArmorItemIterator itemIterator = new ArmorItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Medic)
            {
                MedicItemIterator itemIterator = new MedicItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Stymulant)
            {
                StymulantItemIterator itemIterator = new StymulantItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Euforic)
            {
                EuforicItemIterator itemIterator = new EuforicItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Herbs)
            {
                HerbsItemIterator itemIterator = new HerbsItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.TechnologicalEq)
            {
                TechnologicalEqItemIterator itemIterator = new TechnologicalEqItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }
            if (currentTab.tabType == TabTypes.Custom)
            {
                CustomItemIterator itemIterator = new CustomItemIterator();
                currentTab.DealWithItems(itemIterator.IterateTroughtItems(items));
            }


        }
    }



}
