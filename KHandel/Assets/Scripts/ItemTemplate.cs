using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "item", menuName = "New Item For Sell", order = 1)]
public class ItemTemplate : ScriptableObject
{
    //This is place where we establish type of item.
    public bool isTechnoklan;
    public bool isHanza;
    public bool isSoldat;
    public bool isRytualista;

    public bool isTraweler;

    public bool isCloseWeapon;

    public bool isRangeWeapon;
    public bool isAccesoryForRangeWeapon;
    public bool isThrowingWeapon;

    public bool isArmor;

    public bool isMedic;
    public bool isStymulant;
    public bool isEuforic;

    public bool isHerbs;
    public bool isTechnologicalEq;

    public bool isCustom;
}
