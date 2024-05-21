using System;
using UnityEngine;
using TMPro;

public class ScoreBar : MonoBehaviour
{
    [SerializeField] private TMP_Text _rank1P;
    [SerializeField] private GameObject _Image1P;
    [SerializeField] private TMP_Text _point1P;
    [SerializeField] private TMP_Text _playTime1P;

    [SerializeField] private GameObject _Image2P;
    [SerializeField] private TMP_Text _point2P;
    [SerializeField] private TMP_Text _playTime2P;

    // _record ���� �ܺο��� �����ϴ� �޼���
    public void SetRecord(Record record)
    {
        if (record == null)
        {
            Debug.LogError("ScoreBar.cs - SetRecord() - record is null");
            return;
        }

        if (!record.IsMulti)
        {
            Debug.Log($"ScoreBar.cs - SetRecord() - �̱۽��ھ��");

            int rank = Records.instance.ObjectToIndex(record) + 1;
            _rank1P.text = Convert.ToString($"{rank}");
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;

        }
        else 
        {
            Debug.Log($"ScoreBar.cs - SetRecord() - ��Ƽ���ھ��");

            int rank = Records.instance.ObjectToIndex(record) + 1;
            _rank1P.text = Convert.ToString($"{rank}");
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;
            
            //�̹��� ����
            //_Image2P
            _point2P.text = Convert.ToString(record.Score2P);
            _playTime2P.text = record.PlayTime2P;

        }
             
    }

    public void SetGameOverRecord(Record record)
    {
        if (record == null)
        {
            Debug.LogError("ScoreBar.cs - SetGameOverRecord() - record is null");
            return;
        }

        if (!record.IsMulti)
        {
            Debug.Log($"ScoreBar.cs - SetGameOverRecord() - �̱۽��ھ��");

            _rank1P.text = "-";
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;            
        }
        else
        {
            Debug.Log($"ScoreBar.cs - SetGameOverRecord() - ��Ƽ���ھ��");
        
            _rank1P.text = "-";
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;

            //�̹��� ����
            //_Image2P
            _point2P.text = Convert.ToString(record.Score2P);
            _playTime2P.text = record.PlayTime2P;
        }
    }

    public void SetGameOverRecord(string rank, Record record)
    {
        if (record == null)
        {
            Debug.LogError("ScoreBar.cs - SetGameOverRecord() - record is null");
            return;
        }

        if (!record.IsMulti)
        {
            Debug.Log($"ScoreBar.cs - SetGameOverRecord() - �̱۽��ھ��");

            _rank1P.text = rank;
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;            
        }
        else
        {
            Debug.Log($"ScoreBar.cs - SetGameOverRecord() - ��Ƽ���ھ��");
        
            _rank1P.text = rank;
            //�̹��� ����
            //_Image1P
            _point1P.text = Convert.ToString(record.Score1P);
            _playTime1P.text = record.PlayTime1P;

            //�̹��� ����
            //_Image2P
            _point2P.text = Convert.ToString(record.Score2P);
            _playTime2P.text = record.PlayTime2P;
        }
    }
}
