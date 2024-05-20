using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int type;
    public float shootspeed;

    public void SetBulletType(int bulletType)
    {
        type = bulletType;

        switch (type)
        {
            case 0:
                shootspeed = 0.008f;
                break;
            case 1:
                shootspeed = 0.01f;
                break;
            case 2:
                shootspeed = 0.005f;
                transform.localScale = new Vector2(1f, 1f);
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