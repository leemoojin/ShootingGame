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

           
        }
        //멀티 기록
        else 
        {
            Debug.Log("RecordManager.cs - Awake() - 멀티기록");
          
        }
    }

  
    private void Start()
    {
        //_board.ShowScoreBar();
    }


}
