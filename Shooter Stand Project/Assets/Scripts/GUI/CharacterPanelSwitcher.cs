using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPanelSwitcher : MonoBehaviour
{
    public static CharacterPanelSwitcher panelSwitcher;
    public GameObject[] characterPanels = new GameObject[4];
    public GameObject nextButton;
    public GameObject previousButton;
    public int currentCharacterSelected = 0;

    void Start()
    {
        panelSwitcher = this;
        nextButton.SetActive(true);
        previousButton.SetActive(false);
        CharacterSwitcher();
    }
    void Update()
    {
        if (currentCharacterSelected == 3)
        {
            nextButton.SetActive(false);
        }
        else if (currentCharacterSelected == 0)
        {
            previousButton.SetActive(false);
        }
        else if(currentCharacterSelected>=1 && currentCharacterSelected<=2)
        {
            nextButton.SetActive(true);
            previousButton.SetActive(true);
        }
    }
    public void OnClickNextButton()
    {
        currentCharacterSelected++;
        CharacterSwitcher();
    }

    public void OnClickPreviousButton()
    {
        currentCharacterSelected--;
        CharacterSwitcher();
    }

    private void CharacterSwitcher()
    {
        switch (currentCharacterSelected)
        {
            case 0:
            {  
                    for (int i = 0; i < characterPanels.Length; i++)
                    {
                        if (i == 0)
                        {
                            characterPanels[i].SetActive(true);
                        }
                        else
                        {
                            characterPanels[i].SetActive(false);
                        }
                    }
                    break;
            }
            case 1:
            {
                    for (int i = 0; i < characterPanels.Length; i++)
                    {
                        if (i == 1)
                        {
                            characterPanels[i].SetActive(true);
                        }
                        else
                        {
                            characterPanels[i].SetActive(false);
                        }
                    }
                    break;
            }
            case 2:
            {
                    for (int i = 0; i < characterPanels.Length; i++)
                    {
                        if (i == 2)
                        {
                            characterPanels[i].SetActive(true);
                        }
                        else
                        {
                            characterPanels[i].SetActive(false);
                        }
                    }
                    break;
            }
            case 3:
            {
                    for (int i = 0; i < characterPanels.Length; i++)
                    {
                        if (i == 3)
                        {
                            characterPanels[i].SetActive(true);
                        }
                        else
                        {
                            characterPanels[i].SetActive(false);
                        }
                    }
                    break;
            }
            default:
            {
                    print("Wrong Character Selected");
                    break;
            }
        }
    }
}
