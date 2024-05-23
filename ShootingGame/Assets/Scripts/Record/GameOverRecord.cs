using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameOverRecord : MonoBehaviour
{
    public static GameOverRecord _instance;

    private int _score1P;
    private string _playTime1P;
    private int _score2P;
    private string _playTime2P;

    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject newRecordTxt;

    private Record tempRecord;

    //private string currentSceneName;


    private void Awake()
    {
        Debug.Log("게임오버레코드 웨이크");
        if (_instance == null)
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {       

        if (NewCharacterManager.Instance.spriteName == "PixelArtSpaceShipOne")
        {
            GetRecord(ScoreManager.Instance.totalScore, ScoreManager.Instance.playTime, 0);
        }
        else
        {
            GetRecord(ScoreManager.Instance.totalScore, ScoreManager.Instance.playTime, 1);
        }     

        if (tempRecord == null)
        {
            Debug.Log("게임종료 - 점수획득 실패");
        }

        if (!tempRecord.IsMulti)
        {
            Record record = tempRecord;
            Records.instance.AddRecord(record);

            int rank = Records.instance.ObjectToIndex(record);
            if (rank == -1)
            {
                singleScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(record);
            }
            else
            {
                newRecordTxt.SetActive(true);
                singleScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(Convert.ToString(rank + 1), record);
            }

            singleScoreBar.SetActive(true);
        }
        else
        {
            Record record = tempRecord;
            Records.instance.AddRecord(record);

            int rank = Records.instance.ObjectToIndex(record);
            if (rank == -1)
            {
                multiScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(record);
            }
            else
            {
                newRecordTxt.SetActive(true);
                multiScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(Convert.ToString(rank + 1), record);
            }

            multiScoreBar.SetActive(true);
        }

        SaveLoadManager.Instance.SaveData();
    }

    public void GetRecord(int score1P, string time1P, int image1)
    {
        Debug.Log("레코드 획득");
        tempRecord = new Record(score1P, time1P, image1);
    }

    public void GetRecord(int score1P, string time1P, int score2P, string time2P)
    {
        tempRecord = new Record(score1P, time1P, score2P, time2P);
    }

}
