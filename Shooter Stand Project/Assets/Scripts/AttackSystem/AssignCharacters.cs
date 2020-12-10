using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssignCharacters : MonoBehaviour
{
    public static AssignCharacters assignCharacters;
    public GameObject[] charactersSlots = new GameObject[4];
    public Button[] charactersButtons = new Button[4];
    public string[] characterNames = new string[4];

    public bool[] isFull = new bool[4];

    private void Start()
    {
        assignCharacters = this;
    }
    public void jackAssignButton()
    {
        for (int i = 0; i < charactersSlots.Length; i++)
        {
            if (!isFull[i])
            {
                characterNames[i] = Characters.charactersInfo.characters[0].characterName;
                isFull[i] = true;
                print("Jack has been added to " + (i + 1));

                charactersSlots[i].GetComponent<Image>().color = new Color32(0, 255, 38, 100);
                charactersButtons[0].interactable = false;
                break;
            }
        }
    }
    public void greyhoundAssignButton()
    {
        for (int i = 0; i < charactersSlots.Length; i++)
        {
            if (!isFull[i])
            {
                characterNames[i] = Characters.charactersInfo.characters[1].characterName;
                isFull[i] = true;
                print("GreyHound has been added to " + (i + 1));
                charactersSlots[i].GetComponent<Image>().color = new Color32(153, 153, 153, 100);
                charactersButtons[1].interactable = false;
                break;
            }
        }
    }
    public void slackyAssignButton()
    {
        for (int i = 0; i < charactersSlots.Length; i++)
        {
            if (!isFull[i])
            {
                characterNames[i] = Characters.charactersInfo.characters[2].characterName;
                isFull[i] = true;
                print("Slacky has been added to " + (i + 1));
                charactersSlots[i].GetComponent<Image>().color = new Color32(0, 4, 255, 100);
                charactersButtons[2].interactable = false;
                break;
            }
        }
    }
    public void hotrodAssignButton()
    {
        for (int i = 0; i < charactersSlots.Length; i++)
        {
            if (!isFull[i])
            {
                characterNames[i] = Characters.charactersInfo.characters[3].characterName;
                isFull[i] = true;
                print("Hot Rod has been added to " + (i + 1));
                charactersSlots[i].GetComponent<Image>().color = new Color32(255, 0, 43, 100);
                charactersButtons[3].interactable = false;
                break;
            }
        }
    }
}
