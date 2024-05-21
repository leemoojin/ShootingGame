using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    public int currentHealth;
    [SerializeField]
    private int maximumHealth;
    EnhaceAttackController attackController;
    public bool isInvincible = false;
    [SerializeField] private SpriteRenderer spriteRenderer;
    ShieldController shieldController;

    private void Awake()
    {
        attackController = GetComponent<EnhaceAttackController>();
        shieldController = GetComponent<ShieldController>();
    }

    private void Update()
    {
        if(currentHealth == 0)
        {
            Debug.Log(gameObject + "사망");
            Destroy(gameObject);
            //SceneManager.LoadScene("GameoverScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (currentHealth >= 1 && shieldController.isShieldON == false)
        {
            if (collision.gameObject.CompareTag("EnemyBullet"))
            {
                TakeDamgage(1);
            }
            if (collision.gameObject.CompareTag("Enemy"))
            {
                TakeDamgage(1);
            }
        }
    }


    public void TakeDamgage(int damageAmount)
    {
        
        if (currentHealth >= 1 && shieldController.isShieldON == false)
        {
            currentHealth -= damageAmount;
            attackController.reduceBulletLine(damageAmount);
            isInvincible = true;
            StartCoroutine("InvincibleTime");
            
           
        }
        if(currentHealth < 0 && shieldController.isShieldON == false)
        {
            currentHealth = 0;
            
        }
        Debug.Log("현재 체력" + currentHealth);
    }

    public void AddHealth(int amountToAdd)
    {
        if(currentHealth == maximumHealth)
        {
            return;
        }
        currentHealth += amountToAdd;

        if(currentHealth > maximumHealth)
        {
            currentHealth = maximumHealth;
        }
    }

    IEnumerator InvincibleTime()
    {
        int countTime = 0;
        while (countTime < 10)
        {
            if (countTime % 2 == 0) spriteRenderer.color = new Color32(255, 255, 255, 90);
            else spriteRenderer.color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.2f);
            countTime++;
        }

        spriteRenderer.color = new Color32(255, 255, 255, 255);
        isInvincible = false;
        yield return null;
    }
}
