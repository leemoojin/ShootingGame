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

    private bool IsMulti { get; set; }

    public RecordManager()
    {
        IsMulti = false;
    }

    public RecordManager(bool value)
    {
        IsMulti = value;
    }

    private void Awake()
    {


        //�̱� ���
        if (!IsMulti)
        {
            Debug.Log("�̱۱��");
            //�ӽ÷� Records Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Records Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 
            //_recordList = Records.instance.singleRecords;
            //Record record = new Record(300, "00.30.45");
        }
        //��Ƽ ���
        else 
        {
            Debug.Log("��Ƽ���");
            //�ӽ÷� Records Ŭ������ ���⼭ ��üȭ - �̹� ��üȭ�� Record Ŭ������ ����Ʈ�� �ҷ��;��Ѵ� 
            //_recordList = Records.instance.multiRecords;
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
