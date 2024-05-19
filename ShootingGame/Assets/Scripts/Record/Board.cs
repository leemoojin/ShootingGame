using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : MonoBehaviour
{   
    //프리펩 생성
    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject nullScoreBar;


    //private ScoreBar _scoreBar;
    //private Records _records;

    private void Awake()
    {
        //scoreBar.GetComponent<ScoreBar>();
        //if (!TryGetComponent<GameObject>(out scoreBar)) Debug.Log("Board.cs - Awake() - ScoreBar 참조실패");

        //if (scoreBar == null)
        //{
        //    scoreBar = GameObject.FindGameObjectWithTag("SingleScoreBar");
        //    if (scoreBar == null) Debug.Log("Board.cs - Awake() - ScoreBar 참조실패");

        //}


    }

    // Start is called before the first frame update
    private void Start()
    {
        ShowScoreBar();

    }



    public void ShowScoreBar()
    {
        if (!RecordManager.IsMulti)
        {
            if (Records.instance.singleRecords.Count == 0)
            {
                //널바 10개 생성
            }

            Debug.Log($"Board.cs - ShowScoreBar() - 싱글 레코즈");
            //Debug.Log($"Board.cs - ShowScoreBar() - {Records.instance.singleRecords[0].PlayTime1P}");
            //레코즈에 있는 레코드갯수 만큼 스코어 바를 생성한다 - 프리펩 사용할것
            //ScoreBar _scoreBar = new ScoreBar();
            singleScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.singleRecords[0]);

        }
        else 
        {
            Debug.Log($"Board.cs - ShowScoreBar() - 멀티 레코즈");
            //multiScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.multiRecords[0]);
        }

    }
}
