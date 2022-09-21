using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    [SerializeField] GameObject[] objects;


    private void Start()
    {
        foreach (var item in objects)
        {
            item.SetActive(true);
        }
    }
}
