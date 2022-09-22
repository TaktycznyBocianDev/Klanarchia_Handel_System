using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListsManager : MonoBehaviour
{

    [SerializeField] GameObject[] objects;


    private void SetActiveItemsPlaces(int howMany)
    {
        for (int i = 0; i < howMany; i++)
        {
            objects[i].SetActive(true);
        }
    }
}
