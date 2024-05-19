using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManager : MonoBehaviour
{
    //public Button _multiBtn;


    //private GameObject _singleRecordBar;
    //private GameObject _multiRecordBar;

    //private Records _records;
    //private Record _record;
    //private Board _board;

    
    private List<Record> _recordList;

    private bool _isMulti = false;

    public static bool IsMulti { get; set; }

   

    private void Awake()
    {
        //_board = new Board();

        //�̱� ���
        if (!IsMulti)
        {
            Debug.Log("RecordManager.cs - Awake() - �̱۱��");
            //_recordList = Records.instance.singleRecords;
            //�ӽ÷� Record Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Records Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 
            Records.instance.singleRecords.Add(new Record(300, "00.30.45"));
            Debug.Log($"RecordManager.cs - Awake() - {Records.instance.singleRecords[0].PlayTime1P}");

            //_recordList.Add(new Record(400, "00.40.45"));
            //_recordList.Add(new Record(500, "00.50.45"));

            //Record record = new Record(300, "00.30.45");
        }
        //��Ƽ ���
        else 
        {
            Debug.Log("RecordManager.cs - Awake() - ��Ƽ���");
            //_recordList = Records.instance.multiRecords;
            //�ӽ÷� Record Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Record Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 

            Records.instance.singleRecords.Add(new Record(550, "00.10.25"));
            Debug.Log($"RecordManager.cs - Awake() - {Records.instance.singleRecords[0].PlayTime1P}");

            //Record record = new Record(300, "00.30.45", 400, "00,40,55");
        }
    }

  
    private void Start()
    {
        //_board.ShowScoreBar();
    }



    //private void Update()
    //{
    //    //�̱� ���
    //    if (!IsMulti)
    //    {
    //        Debug.Log("�̱۱��");

    //    }
    //    //��Ƽ ���
    //    else
    //    {
    //        Debug.Log("��Ƽ���");

    //    }
    //}

   





}
