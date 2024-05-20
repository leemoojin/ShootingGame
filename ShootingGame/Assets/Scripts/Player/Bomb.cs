using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class Bomb : MonoBehaviour
{
    //public GameObject bomb;
    [SerializeField] private int bombDamage;
   

    public void BombExplode(GameObject bomb)
    {
        Destroy(bomb);
        if (gameObject.activeInHierarchy)
        {
            if (gameObject.layer == 14)
            {
                //TODO : 적 체력 bombDamage만큼 감소
            }
        }
       
    }
}
