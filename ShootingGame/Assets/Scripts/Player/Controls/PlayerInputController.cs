using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MovementController
{
   
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
        //TODO : 폭탄 사용 구현
        if (value.isPressed)
        {
            Debug.Log("폭탄 사용" + value.ToString());
            CallBombEvent();
        }
    }

}
