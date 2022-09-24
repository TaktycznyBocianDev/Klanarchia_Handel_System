using System;
using UnityEngine;

public class TabsBtnBehav : MonoBehaviour
{

    [SerializeField] TabTypes btnTabType;

    public void WhenTabBtnClick()
    {
        TabsEventManager.UserHasChooseTab(btnTabType);
    }

}
