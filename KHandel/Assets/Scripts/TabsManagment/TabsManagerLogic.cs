using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabsManagerLogic : MonoBehaviour
{
    [SerializeField] GameObject[] tabs;

    private void OnEnable()
    {
        TabsEventManager.userChoose += SetSelectedTabActive;
    }

    private void OnDisable()
    {
        TabsEventManager.userChoose -= SetSelectedTabActive;
    }

    private void Start()
    {

        SetFirstTabActiveOnStart();

    }

    private void SetFirstTabActiveOnStart()
    {
        tabs[0].SetActive(true);
    }


    public void SetSelectedTabActive(TabTypes selectedTabType)
    {
        SetAllUnactive();

        foreach (GameObject tab in tabs)
        {
            if (selectedTabType == tab.GetComponent<TabBehaviour>().tabType)
            {
                tab.SetActive(true);
            }
        }
    }

    public void SetAllUnactive()
    {
        foreach (GameObject tab in tabs)
        {
            tab.SetActive(false);
        }
    }
}
