using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipLoad : MonoBehaviour
{
    public Image spaceshipImage;

    void Start()
    {
        // PlayerPrefs에서 선택된 전투기 이미지 이름을 가져옴
        string selectedSpaceShip = PlayerPrefs.GetString("SelectedSpaceShip");
        // 선택된 전투기 이미지를 Resources 폴더에서 로드
        Sprite spaceshipSprite = Resources.Load<Sprite>("Spaceships/" + selectedSpaceShip);

        if (spaceshipSprite != null )
        {
            // 선택된 전투기 이미지를 UI Image 컴포넌트에 설정
            spaceshipImage.sprite = spaceshipSprite;
        }
        else
        {
            Debug.LogError("Selected spaceship sprite not found");
        }

    }
}
