using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    private Vector3[] positions = new Vector3[3];

    private void Awake()
    {
        positions[0] = new Vector3(-2, 1, 0);
        positions[1] = new Vector3(-5, 1, 3);
        positions[2] = new Vector3(-5, 1, -3);
    }
    public void OnClickLevel1()
    {
        setCharactersLocations();
        //SceneManager.LoadScene("Level1");
    }
    public void OnClickLevel2()
    {
        setCharactersLocations();
        SceneManager.LoadScene("Level2");
    }
    public void setCharactersLocations()
    {
        for (int i = 0; i < 4; i++)
        {
            if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[0])
            {
                Characters.charactersInfo.characters[i].slotActive = 1;
                Characters.charactersInfo.characters[i].tempPosition = positions[0];
                print(Characters.charactersInfo.characters[i].characterName+"Will Spawn First");
            }
            else if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[1])
            {
                Characters.charactersInfo.characters[i].slotActive = 2;
                Characters.charactersInfo.characters[i].tempPosition = positions[1];
                print(Characters.charactersInfo.characters[i].characterName + "Will Spawn At The Top");
            }
            else if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[2])
            {
                Characters.charactersInfo.characters[i].slotActive = 3;
                Characters.charactersInfo.characters[i].tempPosition = positions[2];
                print(Characters.charactersInfo.characters[i].characterName + "Will Spawn At The Bottom");
            }
            else if(AssignCharacters.assignCharacters.characterNames[i]==null)
            {
                print("No characters found at slot:" +i);
            }
        }
        
    }
}
