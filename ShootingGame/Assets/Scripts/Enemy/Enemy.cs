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

    [SerializeField] private GameObject HP;
    [SerializeField] private GameObject EnhanceAttack;
    [SerializeField] private GameObject Bomb;
    [SerializeField] private GameObject Shield;

    

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

    //비행기 생성 정보
    private void setEnemyAttributes()
    {
        switch (type)
        {
            //소형 비행기
            case 0:
                hp = 1;
                speed = 0.3f;
                fireRate = 2f;
                fireRate = 1;
                score = 5;
                break;
            //중형 비행기
            case 1:
                hp = 2;
                speed = 0.5f;
                fireRate = 0.5f;
                score = 10;
                break;
            //대형 비행기
            case 2:
                hp = 5;
                speed = 0.2f;
                fireRate = 1.5f;
                score = 15;
                break;
            //자폭기
            case 3:
                hp = 1;
                speed = 1f;
                score = 10;
                break;
            //운석
            case 4:
                hp = 10;
                speed = 0.1f;
                score = 20;
                break;
            //메테오
            case 5:
                hp = 100;
                speed = 0.8f;
                score = 20;
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
        EnemyBullet bulletScript = BulletInstance.GetComponent<EnemyBullet>();
        bulletScript.SetBulletType(type);
    }

    public void DecreaseEnemyHP(int damage)
    {
        hp -= damage;
        
        if (hp <= 0)
        {
            if(Random.Range(0,1f) <= 0.3f)
            {
                SpawnRandomItem();
                GameManager.Instance.AddScore(score);
                Destroy(gameObject);
            }
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            DecreaseEnemyHP(1);

            float decreaseAmount = 1f / hp;
            GetComponentInChildren<SpriteRenderer>().color = new Color(decreaseAmount, 0, 0, 1);
        }
    }

    private void SpawnRandomItem()
    {
        // 아이템 드롭 확률
        var itemsWithProbabilities = new List<(GameObject, float)>
    {
        (HP, 0.1f),
        (EnhanceAttack, 0.2f),
        (Bomb, 0.1f),
        (Shield, 0.15f)
    };

        
        GameObject selectedItem = GetRandomItemWithProbability(itemsWithProbabilities);

        
        if (selectedItem != null)
        {
            Instantiate(selectedItem, transform.position, Quaternion.identity);
        }
    }

    private GameObject GetRandomItemWithProbability(List<(GameObject, float)> itemsWithProbabilities)
    {
        float totalProbability = 0;
        foreach (var item in itemsWithProbabilities)
        {
            totalProbability += item.Item2;
        }

        float randomPoint = Random.value * totalProbability;

        for (int i = 0; i < itemsWithProbabilities.Count; i++)
        {
            if (randomPoint < itemsWithProbabilities[i].Item2)
            {
                return itemsWithProbabilities[i].Item1;
            }
            else
            {
                randomPoint -= itemsWithProbabilities[i].Item2;
            }
        }
        return null;
    }

}