using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponsList
{
    public string weaponName;
    public int weaponID;

    public int weaponCost;
    public int weaponAmount;

    public int minDamage;
    public int maxDamage;
    public int accuracy;
    public int reload;
    public int clip;

    //public bool isBought;
}
