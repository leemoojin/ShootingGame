using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBtn : MonoBehaviour
{
    public Button selectButton;
    public Sprite characterSprite;

    void Start()
    {
        selectButton.onClick.AddListener(() => CharacterSelect());
    }

    void CharacterSelect()
    {
        SelectCharacter selectCharacter = FindObjectOfType<SelectCharacter>();
        if (selectCharacter != null)
        {
            selectCharacter.CharacterSelecter(characterSprite);
        }
    }
}
