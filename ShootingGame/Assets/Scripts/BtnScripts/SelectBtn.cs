using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectBtn : MonoBehaviour
{
    public Button SelectButton;
    public Sprite CharacterSprite;

    void Start()
    {
        SelectButton.onClick.AddListener(() => Character());
    }

    void Character()
    {
        SelectCharacter selectCharacter = FindObjectOfType<SelectCharacter>();
        if (selectCharacter != null)
        {
            selectCharacter.SelectFighter(CharacterSprite);
        }
    }
}
