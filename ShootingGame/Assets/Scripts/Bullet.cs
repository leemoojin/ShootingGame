using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.down * 0.01f;

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
