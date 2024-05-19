using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;

    public int type;
    public int hp;
    public float speed;
    public float fireRate;

    // Start is called before the first frame update
    public void Start()
    {
        player = GameObject.FindWithTag("Player");

        setEnemyAttributes();

        float x = Random.Range(-2.2f, 2.2f);

        transform.position = new Vector2(x, 5f);

        StartCoroutine(fire());
    }


    // Update is called once per frame
    void Update()
    {
        if (type == 3 && player != null)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    //비행기 생성 정보
    private void setEnemyAttributes()
    {
        switch (type)
        {
            //소형 비행기
            case 0:
                hp = 1;
                speed = 0.3f;
                fireRate = 1;
                break;
            //중형 비행기
            case 1:
                hp = 2;
                speed = 0.5f;
                fireRate = 0.5f;
                break;
            //대형 비행기
            case 2:
                hp = 5;
                speed = 0.2f;
                fireRate = 1.5f;
                break;
            //자폭기
            case 3:
                hp = 1;
                speed = 1f;
                break;
            //운석
            case 4:
                hp = 10;
                speed = 0.1f;
                break;
            //메테오
            case 5:
                hp = 100;
                speed = 0.8f;
                break;

        }
    }

    //총알 생성 간격 조정 적용
    private IEnumerator fire()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }

    //총알 생성
    private void Shoot()
    {
        GameObject BulletInstance = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        Bullet bulletScript = BulletInstance.GetComponent<Bullet>();
        bulletScript.SetBulletType(type);
    }
}
