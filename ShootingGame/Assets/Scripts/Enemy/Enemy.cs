using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player1;
    public GameObject player2;

    int type;
    int hp;
    float speed;
    float fireRate;
    float score;

    // Start is called before the first frame update
    public void Start()
    {
        player1 = GameObject.FindWithTag("Player1");
        player2 = GameObject.FindWithTag("Player2");

        setEnemyAttributes();

        float x = Random.Range(-2.2f, 2.2f);
        transform.position = new Vector2(x, 5f);

        StartCoroutine(fire());
    }


    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (type == 3)
        {
            GameObject targetPlayer = GetClosestPlayer();
            if (targetPlayer != null)
            {
                Vector3 direction = (targetPlayer.transform.position - transform.position).normalized;

                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));

                transform.position += direction * speed * Time.deltaTime;
            }
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

    private GameObject GetClosestPlayer()
    {
        if (player1 == null && player2 == null) return null;
        if (player1 == null) return player2;
        if (player2 == null) return player1;

        float distToPlayer1 = Vector3.Distance(transform.position, player1.transform.position);
        float distToPlayer2 = Vector3.Distance(transform.position, player2.transform.position);

        return distToPlayer1 < distToPlayer2 ? player1 : player2;
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
                score = 5;
                break;
            //���� �����
            case 1:
                hp = 2;
                speed = 0.5f;
                fireRate = 0.5f;
                score = 10;
                break;
            //���� �����
            case 2:
                hp = 5;
                speed = 0.2f;
                fireRate = 1.5f;
                score = 15;
                break;
            //������
            case 3:
                hp = 1;
                speed = 1f;
                score = 10;
                break;
            //�
            case 4:
                hp = 10;
                speed = 0.1f;
                score = 20;
                break;
            //���׿�
            case 5:
                hp = 100;
                speed = 0.8f;
                score = 20;
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
        EnemyBullet bulletScript = BulletInstance.GetComponent<EnemyBullet>();
        bulletScript.SetBulletType(type);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            hp -= 1;

            float decreaseAmount = 1f / hp;
            GetComponentInChildren<SpriteRenderer>().color = new Color(decreaseAmount, 0, 0, 1);

            if (hp <= 0)
            {
                GameManager.Instance.AddScore(score);
                Destroy(gameObject);
            }
        }
    }
}