using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponsGUI : MonoBehaviour
{
    public int weaponID;
    public Text weaponName;
    public Text weaponCost;
    public Text weaponAmount;

    public Image weaponLogo;
    public GameObject buyButton;
    public GameObject equipButton;

    public Text damageUI;
    public Text accuracyUI;
    public Text reloadUI;
    public Text clipUI;
}
