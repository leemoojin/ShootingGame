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
                CallBombEvent();
                bombAmountController.UseBomb(1);
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
