using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public NewCharacter[] newCharacters;

    public int CharacterCount
    {
        get
        {
            return newCharacters.Length;
        }
    }

    public NewCharacter GetNewCharacter(int index)
    {
        return newCharacters[index];
    }

}
