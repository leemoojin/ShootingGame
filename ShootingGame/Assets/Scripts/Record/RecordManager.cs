using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordManager : MonoBehaviour
{
    public Button _multiBtn;


    private GameObject _singleRecordBar;
    private GameObject _multiRecordBar;

    private Records _records;
    private Record _record;

    
    private List<Record> _recordList;

    public static bool IsMulti { get; set; }

   

    private void Awake()
    {        
        //�̱� ���
        if (!IsMulti)
        {
            Debug.Log("RecordManager.cs - Awake() - �̱۱��");
            _recordList = Records.instance.singleRecords;
            //�ӽ÷� Record Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Records Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 

            _recordList.Add(new Record(300, "00.30.45"));
            _recordList.Add(new Record(400, "00.40.45"));
            _recordList.Add(new Record(500, "00.50.45"));

            //Record record = new Record(300, "00.30.45");
        }
        //��Ƽ ���
        else 
        {
            Debug.Log("RecordManager.cs - Awake() - ��Ƽ���");
            _recordList = Records.instance.multiRecords;
            //�ӽ÷� Record Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Record Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 

            //Record record = new Record(300, "00.30.45", 400, "00,40,55");
        }
    }

  
    private void Start()
    {

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
