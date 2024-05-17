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


        //싱글 기록
        if (!IsMulti)
        {
            Debug.Log("싱글기록");
            //임시로 Records 클래스를 여기서 객체화 - 이미 객체화된 Records 클래스의 리스트를 불러와야한다 
            //_recordList = Records.instance.singleRecords;
            //Record record = new Record(300, "00.30.45");
        }
        //멀티 기록
        else 
        {
            Debug.Log("멀티기록");
            //임시로 Records 클래스를 여기서 객체화 - 이미 객체화된 Record 클래스의 리스트를 불러와야한다 
            //_recordList = Records.instance.multiRecords;
            //Record record = new Record(300, "00.30.45", 400, "00,40,55");
        }
    }

  
    private void Start()
    {

    }

    //private void Update()
    //{
    //    //싱글 기록
    //    if (!IsMulti)
    //    {
    //        Debug.Log("싱글기록");

    //    }
    //    //멀티 기록
    //    else
    //    {
    //        Debug.Log("멀티기록");

    //    }
    //}

   





}
