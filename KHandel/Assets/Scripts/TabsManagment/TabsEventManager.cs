using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsEventManager 
{
    public delegate void UserChooseTab(TabTypes tabType);
    public static event UserChooseTab userChoose;

    public static void UserHasChooseTab(TabTypes tabType)
    {

        userChoose?.Invoke(tabType);

    }
}
