using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Bullet;

    public int type;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, 1f);

        float x = Random.Range(-2.2f, 2.2f);
        float y = 5f;

        transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * 0.005f;

        if(transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        Instantiate(Bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }
}
