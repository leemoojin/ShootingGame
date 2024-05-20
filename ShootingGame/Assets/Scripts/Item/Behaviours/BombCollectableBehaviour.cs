using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollectableBehaviour : MonoBehaviour,ICollectableBehaviour
{
    [SerializeField] private int bombAmount;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<BombAmountController>().AddBomb(bombAmount);
    }
}

