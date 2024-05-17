using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Record : MonoBehaviour
{

    [SerializeField] private GameObject _Image1P;
    [SerializeField] private GameObject _point1P;
    [SerializeField] private GameObject _playTime1P;

    [SerializeField] private GameObject _Image2P;
    [SerializeField] private GameObject _point2P;
    [SerializeField] private GameObject _playTime2P;


    public int Score1P { get; set; }
    public string PlayTime1P { get; set; }
    public int Score2P { get; set; }
    public string PlayTime2P { get; set; }
    public bool IsMulti { get; private set; }

    public Record(int score1P, string playTime1P)
    {
        Score1P = score1P;
        PlayTime1P = playTime1P;
        IsMulti = false;
    }

    public Record(int score1P, string playTime1P, int score2P, string playTime2P)
    {
        Score1P = score1P;
        PlayTime1P = playTime1P;
        Score2P = score2P;
        PlayTime2P = playTime2P;
        IsMulti = true;
    }    

}