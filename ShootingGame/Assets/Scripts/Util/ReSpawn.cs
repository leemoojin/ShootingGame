using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    public CharacterDatabase characterDB;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);

    }
    private void UpdateCharacter(int selectedOption)
    {
        NewCharacter newCharacter = characterDB.GetNewCharacter(selectedOption);
        artworkSprite.sprite = newCharacter.characterSprite;

    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }


}
