using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpaceShipBtn : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float rotationSpeed = 50f; // 회전 속도 
    private bool isRotating = true;

    public Button spaceshipBtn;
   
    public Sprite spaceshipSprite;

    
    void Start()
    {   
        
        spaceshipBtn.onClick.AddListener(SelectSpaceShip);

    }

    void Update()
    {
        // 회전 속도에 따라 버튼을 회전시킴
        if (isRotating)
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        // 마우스가 버튼 위에 올라갔을 때 회전을 멈춤
        isRotating = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // 마우스가 버튼을 벗어났을 때 다시 회전을 시작함
        isRotating = true;
    }

    void SelectSpaceShip()
    {
        // 선택된 전투기의 스프라이트 이름을 PlayerPrefs에 저장
        PlayerPrefs.SetString("SelectedSpaceShip", spaceshipSprite.name);
       
        // 메인 씬으로 전환
        SceneManager.LoadScene("MainScene");
    }
}
