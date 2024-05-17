using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    [SerializeField]
    private int currentHealth;
    [SerializeField]
    private int maximumHealth;


    public void TakeDamgage(int damageAmount)
    {
        if (currentHealth == 0)
        {
            return;
        }

        currentHealth -= damageAmount;

        if(currentHealth < 0)
        {
            currentHealth = 0;
        }
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
}
