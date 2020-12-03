using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharactersList
{
    public string characterName;
    public int characterID;

    public int characterCost;
    public int characterHP;

    public bool isUnlocked;
    public bool isHired;
    public bool isOnMission;
    public bool isHealing;

    public int equippedWeaponID;
}
