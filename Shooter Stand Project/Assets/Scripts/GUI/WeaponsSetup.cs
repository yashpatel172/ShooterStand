using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsSetup : MonoBehaviour
{
    public static WeaponsSetup weaponsSetup;
    
    public List<WeaponsList> weapons = new List<WeaponsList>();
    public Transform gridLocation;
    public GameObject weaponHolderPrefab;
    public List<GameObject> tempGUI = new List<GameObject>();
    void Start()
    {
        weaponsSetup = this;
        FillList();
    }

    public void FillList()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            tempGUI[i] = Instantiate(weaponHolderPrefab, gridLocation, false);
            WeaponsGUI weaponsGuiInfo = tempGUI[i].GetComponent<WeaponsGUI>();

            weaponsGuiInfo.weaponID = weapons[i].weaponID;
            weaponsGuiInfo.weaponName.text = weapons[i].weaponName;
            weaponsGuiInfo.weaponCost.text = "$" + weapons[i].weaponCost.ToString();
            weaponsGuiInfo.weaponAmount.text = weapons[i].weaponAmount.ToString();

            weaponsGuiInfo.damageUI.text = weapons[i].minDamage.ToString() + "-" + weapons[i].maxDamage.ToString();
            weaponsGuiInfo.accuracyUI.text = weapons[i].accuracy.ToString() + "%";
            weaponsGuiInfo.reloadUI.text = weapons[i].reload.ToString() + "s";
            weaponsGuiInfo.clipUI.text = weapons[i].clip.ToString();

            weaponsGuiInfo.buyButton.GetComponent<WeaponBuyButton>().weaponID = weapons[i].weaponID;
        }
    }
}
