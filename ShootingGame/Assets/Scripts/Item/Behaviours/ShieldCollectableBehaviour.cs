using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollectableBehaviour : MonoBehaviour, ICollectableBehaviour
{
    [SerializeField] private int shieldHP;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<ShieldController>().GenerateShield(shieldHP);
    }
}
