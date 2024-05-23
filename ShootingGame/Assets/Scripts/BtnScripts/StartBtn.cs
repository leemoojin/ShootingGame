using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBtn : MonoBehaviour
{
    public void Play()
    {
        BGMSoundManager._instance.ChangeBGM(2);
        SceneManager.LoadScene("MainScene");
    }
}
