using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public void CharacterSelecter(Sprite CharacterSprite)
    {
        // ���õ� �������� ��������Ʈ �̸��� PlayerPrefs�� ����
        PlayerPrefs.SetString("CharacterSelecter", CharacterSprite.name);

        
        SceneManager.LoadScene("MainScene");
    }
}
