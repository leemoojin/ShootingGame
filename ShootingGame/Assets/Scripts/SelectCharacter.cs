using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public void SelectFighter(Sprite CharacterSprite)
    {
        // ���õ� �������� ��������Ʈ �̸��� PlayerPrefs�� ����
        PlayerPrefs.SetString("SelectedFighter", CharacterSprite.name);

        
        SceneManager.LoadScene("MainScene");
    }
}
