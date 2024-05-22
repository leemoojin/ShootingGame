using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordBtn : MonoBehaviour
{
    public void MultiBtn()
    {
        Debug.Log("RecordBtn.cs - MultiBtn() - ��Ƽ ��ư Ŭ��");
        
        RecordManager.IsMulti = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SingleBtn()
    {
        Debug.Log("RecordBtn.cs - SingleBtn() - �̱� ��ư Ŭ��");

        RecordManager.IsMulti = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackBtn()
    {
        Debug.Log("�� Ŭ��");
        RecordManager.IsMulti = false;
        SceneManager.LoadScene("MenuScene");
    }

    public void MenuBtn()
    {
        Debug.Log("�޴� Ŭ��");
        RecordManager.IsMulti = false;
        BGMSoundManager._instance.ChangeBGM(1);
        SceneManager.LoadScene("MenuScene");
    }
}
