using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public static LevelSelector levelSelector;
    
    public GameObject assignCharacterPanel;

    public GameObject[] levelButtons = new GameObject[2];
    public GameObject[] levelPanels = new GameObject[2];

    private AssignCharacters assignCharacters;

    void Start()
    {
        levelSelector = this;
        assignCharacters = assignCharacterPanel.GetComponent<AssignCharacters>();
        assignCharacterPanel.SetActive(false);
    }

    public void OnClickLevel1()
    {
        assignCharacterPanel.SetActive(true);
        levelPanels[0].SetActive(true);
    }
    public void OnClickLevel2()
    {
        assignCharacterPanel.SetActive(true);
        levelPanels[1].SetActive(true);
    }
    public void OnClickBackButton()
    {
        for (int i = 0; i < levelPanels.Length; i++)
        {
            levelPanels[i].SetActive(false);
            assignCharacterPanel.SetActive(false);
        }
        for (int i = 0; i < assignCharacters.charactersSlots.Length; i++)
        {
                assignCharacters.isFull[i] = false;
                assignCharacters.characterNames[i] = null;
                assignCharacters.charactersSlots[i].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                assignCharacters.charactersButtons[i].interactable = true;
        }
        for(int i = 0; i < Characters.charactersInfo.characters.Count; i++)
        {
            Characters.charactersInfo.characters[i].tempPosition = Vector3.zero;
        }

    }
}
