using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhanceAttackCollectableBehaviour : MonoBehaviour , ICollectableBehaviour
{
    [SerializeField] private int bulletLine;

    public void OnCollected(GameObject player)
    {
        player.GetComponent<EnhaceAttackController>().AddBulletLine(bulletLine);
    }
}
