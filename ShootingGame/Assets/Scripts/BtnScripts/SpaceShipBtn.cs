using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpaceShipBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float rotationSpeed = 50f; // ȸ�� �ӵ� 
    private bool isRotating = true;

    public Button spaceshipBtn;
   
    public Sprite spaceshipSprite;

    
    void Start()
    {   
        
        spaceshipBtn.onClick.AddListener(SelectSpaceShip);

    }

    void Update()
    {
        // ȸ�� �ӵ��� ���� ��ư�� ȸ����Ŵ
        if (isRotating)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        // ���콺�� ��ư ���� �ö��� �� ȸ���� ����
        isRotating = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // ���콺�� ��ư�� ����� �� �ٽ� ȸ���� ������
        isRotating = true;
    }

    void SelectSpaceShip()
    {
        // ���õ� �������� ��������Ʈ �̸��� PlayerPrefs�� ����
        PlayerPrefs.SetString("SelectedSpaceShip", spaceshipSprite.name);
       
        // ���� ������ ��ȯ
        SceneManager.LoadScene("MainScene");
    }
}
