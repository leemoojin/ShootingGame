﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

[Serializable]
public class Record 
{   
    public int PlayerImage { get; set; }
    public int Score1P { get; set; }
    public string PlayTime1P { get; set; }
    public int Score2P { get; set; }
    public string PlayTime2P { get; set; }
    public bool IsMulti { get; set; }

    public Record(int score1P, string playTime1P, int playerImage)
    {
        Score1P = score1P;
        PlayTime1P = playTime1P;
        IsMulti = false;
        PlayerImage = playerImage;
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