using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WeaponBuyButton : MonoBehaviour
{
    public int weaponID;
    
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

                    print("For Weapon ID: " + weaponID + "This is the current Amount: " + WeaponsSetup.weaponsSetup.weapons[i].weaponAmount);
                }
                else 
                {
                    print("Cant Afford Weapon");
                }
            }
        }
    }
}
