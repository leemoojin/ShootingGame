using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RecordBtn : MonoBehaviour
{
    public void MultiBtn()
    {
        Debug.Log("RecordBtn.cs - MultiBtn() - 멀티 버튼 클릭");
        
        RecordManager.IsMulti = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SingleBtn()
    {
        Debug.Log("RecordBtn.cs - SingleBtn() - 싱글 버튼 클릭");

        RecordManager.IsMulti = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackBtn()
    {
        Debug.Log("백 클릭");
        RecordManager.IsMulti = false;
        SceneManager.LoadScene("MenuScene");
    }

    public void MenuBtn()
    {
        Debug.Log("메뉴 클릭");
        RecordManager.IsMulti = false;
        BGMSoundManager._instance.ChangeBGM(1);
        SceneManager.LoadScene("MenuScene");
    }
}
