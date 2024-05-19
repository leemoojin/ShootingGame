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

        //싱글 기록
        if (!IsMulti)
        {
            Debug.Log("RecordManager.cs - Awake() - 싱글기록");
            //_recordList = Records.instance.singleRecords;
            //임시로 Record 클래스를 여기서 객체화 - 이미 객체화된 Records 클래스의 리스트를 불러와야한다 
            Records.instance.singleRecords.Add(new Record(300, "00.30.45"));
            Debug.Log($"RecordManager.cs - Awake() - {Records.instance.singleRecords[0].PlayTime1P}");

            //_recordList.Add(new Record(400, "00.40.45"));
            //_recordList.Add(new Record(500, "00.50.45"));

            //Record record = new Record(300, "00.30.45");
        }
        //멀티 기록
        else 
        {
            Debug.Log("RecordManager.cs - Awake() - 멀티기록");
            //_recordList = Records.instance.multiRecords;
            //임시로 Record 클래스를 여기서 객체화 - 이미 객체화된 Record 클래스의 리스트를 불러와야한다 

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
