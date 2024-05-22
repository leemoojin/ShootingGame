using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimController : MonoBehaviour
{
    private Animator animator;
    

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void DestroyAnimation()
    {
        Debug.Log("Àû »ç¸Á ¾Ö´Ô");
       animator.SetTrigger("Destroy");
        
    }
}
