using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;

    public int type;
    public int hp;
    public float speed;
    public float fireRate;

    // Start is called before the first frame update
    public void Start()
    {
        setEnemyAttributes();

        float x = Random.Range(-2.2f, 2.2f);

        transform.position = new Vector2(x, 5f);

        StartCoroutine(fire());
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

    private void setEnemyAttributes()
    {
        switch (type)
        {
            //소형 비행기
            case 0:
                hp = 1;
                speed = 0.003f;
                fireRate = 1;
                break;
            //중형 비행기
            case 1:
                hp = 2;
                speed = 0.005f;
                fireRate = 0.5f;
                break;
            //대형 비행기
            case 2:
                hp = 5;
                speed = 0.002f;
                fireRate = 1.5f;
                break;
            //자폭기
            case 3:
                hp = 1;
                speed = 0.005f;
                break;
            //운석
            case 4:
                hp = 10;
                speed = 0.001f;
                break;
            //메테오
            case 5:
                hp = 100;
                speed = 0.008f;
                break;

        }
    }

    private IEnumerator fire()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }

    private void Shoot()
    {
        GameObject BulletInstance = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        Bullet bulletScript = BulletInstance.GetComponent<Bullet>();
        bulletScript.SetBuletType(type);
    }
}
