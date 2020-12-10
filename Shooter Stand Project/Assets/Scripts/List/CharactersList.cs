using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CharactersList
{
    public string characterName;
    public int characterID;

    public int characterCost;
    public int currentCharacterHP;
    public int maxCharacterHP;

    public bool isUnlocked;
    public bool isHired;
    public bool isOnMission;
    public bool isHealing;
    public bool isDead;

    public int equippedWeaponID;

    public GameObject characterModel;
    public int slotActive;
    public Vector3 tempPosition;
}
