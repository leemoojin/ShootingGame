using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameOverRecord : MonoBehaviour
{
    public static GameOverRecord _instance;

    //���� ���� �� ���޹��� ������
    //private bool _isMulti;
    private int _score1P;
    private string _playTime1P;
    private int _score2P;
    private string _playTime2P;

    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject newRecordTxt;

    private Record tempRecord;

    private string currentSceneName;


    private void Awake()
    {
        Debug.Log("���ӿ������ڵ� ����ũ");
        if (_instance == null)
        {
            _instance = this;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName != "GameoverScene") return;

        //�ӽ÷� �ַ� �÷��̷� ����
        //_isMulti = false;
        //_score1P = 500;
        //_playTime1P = "00.20.35";

        //string time = ScoreManager.Instance.time.ToString("N2");
        //GetRecord(ScoreManager.Instance.score, time);

        if (tempRecord == null)
        {
            Debug.Log("�������� - ����ȹ�� ����");
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
        Debug.Log("���ڵ� ȹ��");
        tempRecord = new Record(score1P, time1P, image1);
    }

    public void GetRecord(int score1P, string time1P, int score2P, string time2P)
    {
        tempRecord = new Record(score1P, time1P, score2P, time2P);
    }

}
