using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MovementController
{
    BombAmountController bombAmountController;

    private void Awake()
    {
        bombAmountController = GetComponent<BombAmountController>();
    }

    private void Update()
    {
        // 플레이어의 현재 위치를 가져오기.
        Vector3 position = transform.position;

        // 카메라의 반경을 계산.
        float screenRatio = (float)Screen.width / (float)Screen.height;
        float cameraHeight = Camera.main.orthographicSize;
        float cameraWidth = cameraHeight * screenRatio;

        // 플레이어의 위치를 카메라의 경계 내로 제한.
        position.x = Mathf.Clamp(position.x, -cameraWidth, cameraWidth);
        position.y = Mathf.Clamp(position.y, -cameraHeight, cameraHeight);

        // 제한된 위치를 플레이어에 적용.
        transform.position = position;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnFire(InputValue value)
    {
       isPressed = value.isPressed;
        
        if(isPressed)
        {
            EffectsSoundManager._instance.PlayAttackSound();
            CallFireEvent();
        }
    }

    public void OnBomb(InputValue value)
    {
        isPressed_bomb = value.isPressed;
        int bombUse = 1;

        if (bombAmountController.currentBombCount >= 1)
        {
            if (isPressed_bomb)
            {
                Debug.Log("폭탄 사용" + value.ToString());
                EffectsSoundManager._instance.PlayBombSound();
                CallBombEvent();
                bombAmountController.UseBomb(bombUse);
                isPressed_bomb = false;
            }
        }
        else if(bombAmountController.currentBombCount <= 0)
        {
            isPressed_bomb=false;
            return;
        }
    }

}
