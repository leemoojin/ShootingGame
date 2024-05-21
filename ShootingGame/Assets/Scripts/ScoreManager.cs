using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text TimeTxt;
    public Text ScoreTxt;

    private int score;
    private float time = 0.0f;
    private float scoreFromTime = 0.0f;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        scoreFromTime = time; // 시간에 따른 점수 계산
        TimeTxt.text = time.ToString("N2");
        UpdateScoreText();
    }

    public void AddScore(float value)
    {
        score += (int)value;
        UpdateScoreText(); // 점수 업데이트
    }

    private void UpdateScoreText()
    {
        ScoreTxt.text = (score + scoreFromTime).ToString("N2"); // 현재 점수 + 시간에 따른 점수 업데이트
    }
}