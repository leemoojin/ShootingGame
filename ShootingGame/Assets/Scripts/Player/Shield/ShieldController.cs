using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    [SerializeField] private int currentShieldHP;
    [SerializeField] private int maxShieldHP = 2;
    [SerializeField] private GameObject shield;
    public bool isShieldON = false;
    private bool isInvincible = false;

    public void TakeDamage(int damageAmount)
    {
        if(currentShieldHP == 0)
        {
            shield.SetActive(false);
            isShieldON = false;
        }
        StartCoroutine(ShieldInvincible());
        currentShieldHP -= damageAmount;

        if(currentShieldHP < 0)
        {
            currentShieldHP = 0;
            isShieldON = false;
        }
    }

    IEnumerator ShieldInvincible()
    {
        isInvincible = true;
        yield return new WaitForSeconds(0.3f);
        isInvincible = false;
    }

    public void GenerateShield(int shieldHP)
    {
        
        if(currentShieldHP == maxShieldHP)
        {
            return;
        }
        shield.SetActive(true);
        currentShieldHP = shieldHP;
        isShieldON = true;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            TakeDamage(1);
        }
    }
}
