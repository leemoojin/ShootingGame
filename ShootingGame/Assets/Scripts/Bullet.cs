using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int type;
    public float shootspeed;

    private void Start()
    {
        switch(type)
        {
            case 0:
                shootspeed = 0.005f;
                break;
            case 1:
                shootspeed = 0.007f;
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
