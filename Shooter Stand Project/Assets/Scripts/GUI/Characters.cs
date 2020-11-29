using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Characters : MonoBehaviour
{
    public static Characters charactersInfo;
    public List<CharactersList> characters = new List<CharactersList>();

    public GameObject[] lockedTexts;
    public GameObject[] characterBuyButtons;
    public Text[] statusTexts;

    void Start()
    {
        charactersInfo = this;
    }

    void Update()
    {
        checkCharacterUnlocked();
    }

    public void checkCharacterUnlocked()
    {
        for (int i = 0; i < characters.Count; i++)
        {
            if (characters[i].isUnlocked)
            {
                lockedTexts[i].SetActive(false);
                characterBuyButtons[i].SetActive(true);
            }
            else if (!characters[i].isUnlocked)
            {
                lockedTexts[i].SetActive(true);
                characterBuyButtons[i].SetActive(false);
            }
            if (characters[i].isHired)
            {
                characterBuyButtons[i].SetActive(false);
                statusTexts[i].text = "HIRED";
            }
        }
    }

    public void OnClickJackBuyButton()
    {
        characterBuyButtons[0].SetActive(false);
    }
    public void OnClickGreyhoundBuyButton()
    {
        if (!characters[1].isHired && characters[1].isUnlocked)
        {
            if (PlayerResources.playerResources.cash >= characters[1].characterCost)
            {
                characters[1].isHired = true ;
                PlayerResources.playerResources.ReduceCash(characters[1].characterCost);
                statusTexts[1].text = "HIRED";
                characterBuyButtons[1].SetActive(false);
                print("You Bought GreyHound");
            }
            else
            {
                print("Cant Afford GreyHound");
            }
        }
    }
    public void OnClickSlackyBuyButton()
    {
        if (!characters[2].isHired && characters[2].isUnlocked)
        {
            if (PlayerResources.playerResources.cash >= characters[2].characterCost)
            {
                characters[2].isHired = true;
                PlayerResources.playerResources.ReduceCash(characters[2].characterCost);
                statusTexts[2].text = "HIRED";
                characterBuyButtons[2].SetActive(false);
                print("You Bought Slacky");
            }
            else
            {
                print("Cant Afford Slacky");
            }
        }
    }
    public void OnClickHotrodBuyButton()
    {
        if (!characters[3].isHired && characters[3].isUnlocked)
        {
            if (PlayerResources.playerResources.cash >= characters[3].characterCost)
            {
                characters[3].isHired = true;
                PlayerResources.playerResources.ReduceCash(characters[3].characterCost);
                statusTexts[3].text = "HIRED";
                characterBuyButtons[3].SetActive(false);
                print("You Bought HotRod");
            }
            else
            {
                print("Cant Afford HotRod");
            }
        }
    }

}
