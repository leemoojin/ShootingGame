using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCharacter : MonoBehaviour
{
    public void SelectFighter(Sprite CharacterSprite)
    {
        // 선택된 전투기의 스프라이트 이름을 PlayerPrefs에 저장
        PlayerPrefs.SetString("SelectedFighter", CharacterSprite.name);

        
        SceneManager.LoadScene("MainScene");
    }
}
