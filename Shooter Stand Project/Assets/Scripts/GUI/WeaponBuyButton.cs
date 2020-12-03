using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponBuyButton : MonoBehaviour
{
    public int weaponID;
    void Start()
    {
        for (int i = 0; i < WeaponsSetup.weaponsSetup.weapons.Count; i++)
        {
            if (WeaponsSetup.weaponsSetup.weapons[i].weaponID == weaponID)
            {
                WeaponsGUI temp = WeaponsSetup.weaponsSetup.tempGUI[i].GetComponent<WeaponsGUI>();
                if (WeaponsSetup.weaponsSetup.weapons[i].weaponAmount > 0)
                {
                    temp.weaponAmount.text = WeaponsSetup.weaponsSetup.weapons[i].weaponAmount.ToString();
                    temp.buyButton.SetActive(false);
                    temp.equipButton.SetActive(true);
                }
                if (WeaponsSetup.weaponsSetup.weapons[i].weaponAmount == 0)
                {
                    temp.weaponAmount.text = WeaponsSetup.weaponsSetup.weapons[i].weaponAmount.ToString();
                    temp.buyButton.SetActive(true);
                    temp.equipButton.SetActive(false);
                }
            }
            else
            {
                print("Error while checking amount!");
            }

        }
    }

    private void Update()
    {
        
    }
    public void OnClickBuyWeaponButton()
    {
        if (weaponID == 0)
        {
            print("Invalid Weapon ID");
            return;
        }

        for (int i = 0; i < WeaponsSetup.weaponsSetup.weapons.Count; i++)
        {
            if (WeaponsSetup.weaponsSetup.weapons[i].weaponID == weaponID)
            {
                if (PlayerResources.playerResources.cash >= WeaponsSetup.weaponsSetup.weapons[i].weaponCost)
                {
                    WeaponsSetup.weaponsSetup.weapons[i].weaponAmount += 1;
                    PlayerResources.playerResources.ReduceCash(WeaponsSetup.weaponsSetup.weapons[i].weaponCost);

                    WeaponsGUI temp = WeaponsSetup.weaponsSetup.tempGUI[i].GetComponent<WeaponsGUI>();
                    temp.weaponAmount.text = WeaponsSetup.weaponsSetup.weapons[i].weaponAmount.ToString();
                    temp.buyButton.SetActive(false);
                    temp.equipButton.SetActive(true);
                    print("For Weapon ID: " + weaponID + "This is the current Amount: " + WeaponsSetup.weaponsSetup.weapons[i].weaponAmount);
                }
                else 
                {
                    print("Cant Afford Weapon");
                }
            }
        }
    }

    public void OnClickEquipWeaponButton()
    {
        if (weaponID == 0)
        {
            print("Invalid Weapon Equipping");
            return;
        }
        for (int i = 0; i < WeaponsSetup.weaponsSetup.weapons.Count; i++)
        {
            WeaponsGUI temp = WeaponsSetup.weaponsSetup.tempGUI[i].GetComponent<WeaponsGUI>();
                if (WeaponsSetup.weaponsSetup.weapons[i].weaponID == weaponID)
                {
                    if (Characters.charactersInfo.characters[CharacterPanelSwitcher.panelSwitcher.currentCharacterSelected].equippedWeaponID == weaponID)
                    {
                        print("you cant equip the weapon TWICE! BREAK!");
                        break;
                    }
                    if (Characters.charactersInfo.characters[CharacterPanelSwitcher.panelSwitcher.currentCharacterSelected].equippedWeaponID != weaponID)
                    {
                        print("Equip Function Starts!");
                        WeaponsSetup.weaponsSetup.weapons[i].weaponAmount--;
                        temp.weaponAmount.text = WeaponsSetup.weaponsSetup.weapons[i].weaponAmount.ToString();

                        int wTemp = Characters.charactersInfo.characters[CharacterPanelSwitcher.panelSwitcher.currentCharacterSelected].equippedWeaponID - 1;
                        WeaponsSetup.weaponsSetup.weapons[wTemp].weaponAmount++;
                        WeaponsGUI miniTemp = WeaponsSetup.weaponsSetup.tempGUI[wTemp].GetComponent<WeaponsGUI>();
                        miniTemp.weaponAmount.text = WeaponsSetup.weaponsSetup.weapons[wTemp].weaponAmount.ToString();

                    Characters.charactersInfo.characters[CharacterPanelSwitcher.panelSwitcher.currentCharacterSelected].equippedWeaponID = weaponID;
                    }
                    else
                    {
                        print("Invalid Weapon Check!");
                    }

                    //UI STUFF
                    if (WeaponsSetup.weaponsSetup.weapons[i].weaponAmount > 0)
                    {
                        temp.buyButton.SetActive(false);
                        temp.equipButton.SetActive(true);
                    }
                    else if (WeaponsSetup.weaponsSetup.weapons[i].weaponAmount == 0)
                    {
                        temp.buyButton.SetActive(true);
                        temp.equipButton.SetActive(false);
                    }
            }
        }
    }
}
