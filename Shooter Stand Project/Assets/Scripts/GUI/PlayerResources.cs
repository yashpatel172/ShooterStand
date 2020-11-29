using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerResources : MonoBehaviour
{
    public static PlayerResources playerResources;
    public int cash = 9000;
    public Text cashText;
    void Start()
    {
        playerResources = this;
        UpdateUI();
    }
    public void AddCash(int amount)
    {
        cash += amount;
        UpdateUI();
    }
    public void ReduceCash(int amount)
    {
        cash -= amount;
        UpdateUI();
        if (cash <= 0)
        {
            cash = 0;
            UpdateUI();
        }
    }
    public void UpdateUI()
    {
        cashText.text = "$"+cash.ToString();
    }
}
