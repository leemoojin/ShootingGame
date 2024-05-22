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
                shootspeed = 1.5f;
                break;
            case 1:
                shootspeed = 2f;
                break;
            case 2:
                shootspeed = 1f;
                transform.localScale = new Vector2(1f, 1f);
                break;
        }
    }
    void Update()
    {
        transform.position += Vector3.down * shootspeed * Time.deltaTime;

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}