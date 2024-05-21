using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameOverRecord : MonoBehaviour
{

    //게임 오버 후 전달받을 데이터
    private bool _isMulti;
    private int _score1P;
    private string _playTime1P;
    private int _score2P;
    private string _playTime2P;

    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject newRecordTxt;


    // Start is called before the first frame update
    void Start()
    {   
        //임시로 솔로 플레이로 설정
        _isMulti = false;
        _score1P = 500;
        _playTime1P = "00.20.35";

        if (!_isMulti)
        {
            Record record = new Record(_score1P, _playTime1P);
            Records.instance.AddRecord(record);

            int rank = Records.instance.ObjectToIndex(record);
            if (rank == -1)
            {
                singleScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(record);
            }
            else 
            {
                newRecordTxt.SetActive(true);
                singleScoreBar.GetComponent<ScoreBar>().SetGameOverRecord(Convert.ToString(rank + 1) ,record);
            }

            singleScoreBar.SetActive(true);
        }
        else 
        {
            Record record = new Record(_score1P, _playTime1P, _score2P, _playTime2P);
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
        
    }

   
}
