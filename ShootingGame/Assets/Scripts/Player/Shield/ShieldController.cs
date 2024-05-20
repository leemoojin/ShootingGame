using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
    [SerializeField] private int currentShieldHP;
    [SerializeField] private int maxShieldHP = 2;
    [SerializeField] private GameObject shield;

    public void TakeDamage(int damageAmount)
    {
        if(currentShieldHP == 0)
        {
            shield.SetActive(false);
        }
        currentShieldHP -= damageAmount;

        if(currentShieldHP < 0)
        {
            currentShieldHP = 0;
        }
    }

    public void GenerateShield(int shieldHP)
    {
        if(currentShieldHP == maxShieldHP)
        {
            return;
        }
        shield.SetActive(true);
        currentShieldHP = shieldHP;
    }
}
