using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : MonoBehaviour
{   
    //������ ����
    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject nullScoreBar;


    //private ScoreBar _scoreBar;
    //private Records _records;

    private void Awake()
    {
        //scoreBar.GetComponent<ScoreBar>();
        //if (!TryGetComponent<GameObject>(out scoreBar)) Debug.Log("Board.cs - Awake() - ScoreBar ��������");

        //if (scoreBar == null)
        //{
        //    scoreBar = GameObject.FindGameObjectWithTag("SingleScoreBar");
        //    if (scoreBar == null) Debug.Log("Board.cs - Awake() - ScoreBar ��������");

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
                //�ι� 10�� ����
            }

            Debug.Log($"Board.cs - ShowScoreBar() - �̱� ������");
            //Debug.Log($"Board.cs - ShowScoreBar() - {Records.instance.singleRecords[0].PlayTime1P}");
            //����� �ִ� ���ڵ尹�� ��ŭ ���ھ� �ٸ� �����Ѵ� - ������ ����Ұ�
            //ScoreBar _scoreBar = new ScoreBar();
            singleScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.singleRecords[0]);

        }
        else 
        {
            Debug.Log($"Board.cs - ShowScoreBar() - ��Ƽ ������");
            //multiScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.multiRecords[0]);
        }

    }
}
