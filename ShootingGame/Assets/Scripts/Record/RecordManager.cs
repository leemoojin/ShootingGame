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

           
        }
        //��Ƽ ���
        else 
        {
            Debug.Log("RecordManager.cs - Awake() - ��Ƽ���");
          
        }
    }

  
    private void Start()
    {
        //_board.ShowScoreBar();
    }


}
