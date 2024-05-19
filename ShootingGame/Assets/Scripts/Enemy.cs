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

    //����� ���� ����
    private void setEnemyAttributes()
    {
        switch (type)
        {
            //���� �����
            case 0:
                hp = 1;
                speed = 0.3f;
                fireRate = 1;
                break;
            //���� �����
            case 1:
                hp = 2;
                speed = 0.5f;
                fireRate = 0.5f;
                break;
            //���� �����
            case 2:
                hp = 5;
                speed = 0.2f;
                fireRate = 1.5f;
                break;
            //������
            case 3:
                hp = 1;
                speed = 1f;
                break;
            //�
            case 4:
                hp = 10;
                speed = 0.1f;
                break;
            //���׿�
            case 5:
                hp = 100;
                speed = 0.8f;
                break;

        }
    }

    //�Ѿ� ���� ���� ���� ����
    private IEnumerator fire()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(fireRate);
        }
    }

    //�Ѿ� ����
    private void Shoot()
    {
        GameObject BulletInstance = Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        Bullet bulletScript = BulletInstance.GetComponent<Bullet>();
        bulletScript.SetBulletType(type);
    }
}
