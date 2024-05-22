using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSoundManager : MonoBehaviour
{
    public AudioClip attackClip;
    private AudioSource audioSource;

    public static EffectsSoundManager _instance;


    private void Awake()
    {
        if (_instance == null) _instance = this;

        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        

        
    }

    public void PlayAttackSound()
    {
        // AudioSource에 공격 효과음 클립 설정
        audioSource.clip = attackClip;
        audioSource.Play();
    }
}
