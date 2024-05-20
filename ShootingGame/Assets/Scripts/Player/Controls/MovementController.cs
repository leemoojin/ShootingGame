using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action OnFireEvent;
    public event Action OnBombEvent;
    public bool isPressed;
    public bool isPressed_bomb;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent(direction);
    }

   public void CallFireEvent()
    {
        OnFireEvent();
    }

    public void CallBombEvent()
    {
        OnBombEvent();
    }
}
