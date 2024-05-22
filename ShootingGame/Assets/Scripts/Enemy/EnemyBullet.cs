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
                shootspeed = 3f;
                break;
            case 1:
                shootspeed = 5f;
                break;
            case 2:
                shootspeed = 2f;
                transform.localScale = new Vector2(3f, 3f);
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