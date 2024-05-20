using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private MovementController movementController;
    private Rigidbody2D movementRigidbody;

    EnhaceAttackController attackController;
    
    private Vector2 movementDirection = Vector2.zero;

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootPoint;
    [SerializeField] private Transform[] shootpoints2;
    [SerializeField] private Transform[] shootpoints3;
    [SerializeField] private Transform[] shootpoints4;
    [SerializeField] private float bulletSpeed;

    private bool wasPressed = false;

    private void Awake()
    {
        movementController = GetComponent<MovementController>();
        movementRigidbody = GetComponent<Rigidbody2D>();      
        attackController = GetComponent<EnhaceAttackController>();
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
        switch (attackController.currentBulletLine)
        {
            case 1:
                FireOneLine();
                break;
            case 2:
                FireTwoLines();
                break;
            case 3:
                FireThreeLines();
                break;
            case 4:
                FireFourLines();
                break;
        }
        
        
        
        
    }

    private void FireOneLine()
    {
        Debug.Log("Fire");
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.velocity = bulletSpeed * Vector2.up;
    }

    private void FireTwoLines()
    {
        foreach (Transform point in shootpoints2)
        {
            Debug.Log("Fire2");
            GameObject bullet = Instantiate(bulletPrefab, point.position, Quaternion.identity);

            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            rigidbody.velocity = bulletSpeed * Vector2.up;
        }
    }

    private void FireThreeLines()
    {
        foreach (Transform point in shootpoints3)
        {
            Debug.Log("Fire3");
            GameObject bullet = Instantiate(bulletPrefab, point.position, Quaternion.identity);

            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            rigidbody.velocity = bulletSpeed * Vector2.up;
        }
    }

    private void FireFourLines()
    {
        foreach (Transform point in shootpoints4)
        {
            Debug.Log("Fire4");
            GameObject bullet = Instantiate(bulletPrefab, point.position, Quaternion.identity);

            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            rigidbody.velocity = bulletSpeed * Vector2.up;
        }
    }

    private void Bomb()
    {
        
    }

  

}
