using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GridBehaviour : MonoBehaviour
{
    public static void SetPanelOfItemOnCorrectSize(RectTransform rectTransformOfGrid, int howManyItemIs, float startingSize, float howMuchAdd)
    {

       float finalSize = startingSize + (howMuchAdd * howManyItemIs);

        RectTransformExtensions.SetBottom(rectTransformOfGrid, finalSize);
    }
}
