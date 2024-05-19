using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int type;
    public float shootspeed;

    public void SetBuletType(int bulletType)
    {
        type = bulletType;

        switch(type)
        {
            case 0:
                shootspeed = 0.008f;
                break;
            case 1:
                shootspeed = 0.01f;
                break;
            case 2:
                shootspeed = 0.005f;
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
