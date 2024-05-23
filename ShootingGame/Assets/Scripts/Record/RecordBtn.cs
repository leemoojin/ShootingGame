using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordBtn : MonoBehaviour
{
    public void MultiBtn()
    { 
        Board.IsMulti = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SingleBtn()
    {

        Board.IsMulti = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackBtn()
    {
        Board.IsMulti = false;
        SceneManager.LoadScene("MenuScene");
    }

    public void MenuBtn()
    {
        Board.IsMulti = false;
        BGMSoundManager._instance.ChangeBGM(1);
        SceneManager.LoadScene("MenuScene");
    }
}
