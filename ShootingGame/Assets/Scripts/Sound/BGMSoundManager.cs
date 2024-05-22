using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMSoundManager : MonoBehaviour
{
    public AudioClip[] backgroundMusic;
    private AudioSource audioSource;

    private string currentSceneName;
    public static BGMSoundManager _instance;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName != "MenuScene") return;

        if (_instance == null)
        {
            Debug.Log("SoundManager -  DontDestroyOnLoad");
            _instance = this;           
            DontDestroyOnLoad(gameObject);
        }
        else
        {

            Debug.Log("SoundManager -  Destroy");
            Destroy(gameObject);
        }

    }

    private void Start()
    {

        if (currentSceneName == "IntroScene")
        {
            PlayBGM(0);
        }

        if (currentSceneName == "MenuScene")
        {
            PlayBGM(1);
        }
    }

    public void PlayBGM(int index)
    {
        audioSource.clip = backgroundMusic[index];
        audioSource.Play();
    }

    public void ChangeBGM(int index)
    {
        audioSource.Stop();
        audioSource.clip = backgroundMusic[index];
        audioSource.Play();
    }
}
