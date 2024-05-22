using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsSoundManager : MonoBehaviour
{
    public AudioClip[] attackClips;
    private AudioSource audioSource;

    public static EffectsSoundManager _instance;


    private void Awake()
    {
        if (_instance == null) _instance = this;

        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAttackSound()
    {
        // AudioSource에 공격 효과음 클립 설정
        audioSource.volume = 0.15f;
        audioSource.clip = attackClips[0];
        audioSource.Play();
    }

    public void PlayBombSound()
    {
        audioSource.volume = 0.7f;
        audioSource.clip = attackClips[1];
        audioSource.Play();
    }
}
