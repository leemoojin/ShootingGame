using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int type;
    public float shootspeed;

    private void Start()
    {
        Enemy enemy = new Enemy();
        type = enemy.type;

        switch(type)
        {
            case 0:
                shootspeed = 0.005f;
                break;
            case 1:
                shootspeed = 0.007f;
                break;
            case 2:
                shootspeed = 0.003f;
                transform.localScale = new Vector2(1.5f, 1.5f);
                break;
        }
    }
    void Update()
    {
        transform.position += Vector3.down * shootspeed;

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
