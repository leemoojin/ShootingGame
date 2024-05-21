using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipLoad : MonoBehaviour
{
    public Image spaceshipImage;

    void Start()
    {
        // PlayerPrefs���� ���õ� ������ �̹��� �̸��� ������
        string selectedSpaceShip = PlayerPrefs.GetString("SelectedSpaceShip");
        // ���õ� ������ �̹����� Resources �������� �ε�
        Sprite spaceshipSprite = Resources.Load<Sprite>("Spaceships/" + selectedSpaceShip);

        if (spaceshipSprite != null )
        {
            // ���õ� ������ �̹����� UI Image ������Ʈ�� ����
            spaceshipImage.sprite = spaceshipSprite;
        }
        else
        {
            Debug.LogError("Selected spaceship sprite not found");
        }

    }
}
