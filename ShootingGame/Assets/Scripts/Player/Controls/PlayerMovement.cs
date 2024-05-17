using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private MovementController movementController;
    private Rigidbody2D movementRigidbody;

    private Rigidbody2D bulletRigidbody;
    private Vector2 movementDirection = Vector2.zero;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private float bulletSpeed;

    private bool wasPressed = false;

    private void Awake()
    {
        movementController = GetComponent<MovementController>();
        movementRigidbody = GetComponent<Rigidbody2D>();      
    }

    private void Start()
    {
        movementController.OnMoveEvent += Move;
        movementController.OnFireEvent += Fire;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
        
        if (movementController.isPressed && !wasPressed)
        {
            Fire();
        }
        wasPressed = movementController.isPressed;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }


    private void Fire()
    {
        Debug.Log("Fire");
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.velocity = bulletSpeed * Vector2.up;
    }

    private void Bomb()
    {
        
    }

  

}
