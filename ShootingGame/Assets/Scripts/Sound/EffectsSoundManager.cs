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
        // AudioSource�� ���� ȿ���� Ŭ�� ����
        audioSource.clip = attackClip;
        audioSource.Play();
    }
}
