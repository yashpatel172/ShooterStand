using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Script : MonoBehaviour
{
    //int playerCounter = 0;

    private void Start()
    {
        /* for (int i = 0; i < 4; i++)
         {
             if (AssignCharacters.assignCharacters.characterNames[i] == "")
             {
                 print("Found Empty Slot");
                 break;
             }
             else
             {
                 playerCounter++;
             }
         }

         print(playerCounter);*/
        loadCharacters();
    }

    void loadCharacters()
    {
        for (int i = 0; i < 4; i++)
        {
            if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[0])
            {
                Instantiate(Characters.charactersInfo.characters[i].characterModel, Characters.charactersInfo.characters[i].tempPosition, Quaternion.identity);
            }
            else if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[1])
            {
                Instantiate(Characters.charactersInfo.characters[i].characterModel, Characters.charactersInfo.characters[i].tempPosition, Quaternion.identity);
            }
            else if (Characters.charactersInfo.characters[i].characterName == AssignCharacters.assignCharacters.characterNames[2])
            {
                Instantiate(Characters.charactersInfo.characters[i].characterModel, Characters.charactersInfo.characters[i].tempPosition, Quaternion.identity);
            }
        }
    }
}
