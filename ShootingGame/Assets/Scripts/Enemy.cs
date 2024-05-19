using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Bullet;

    public int type;
    public int hp;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Shoot", 0f, 1f);

        float x = Random.Range(-2.2f, 2.2f);

        transform.position = new Vector2(x, 5f);

        switch(type)
        {
            //���� �����
            case 0:
                hp = 1;
                speed = 0.003f;
                break;
            //���� �����
            case 1:
                hp = 2;
                speed = 0.005f;
                break;
            //���� �����
            case 2:
                hp = 5;
                speed = 0.002f;
                break;
            //������
            case 3:
                hp = 1;
                speed = 0.005f;
                break;
            //�
            case 4:
                hp = 10;
                speed = 0.001f;
                break;
            //���׿�
            case 5:
                hp = 100;
                speed = 0.008f;
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed;

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
