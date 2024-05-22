using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public Text TimeTxt;
    public Text ScoreTxt;

    public int score;
    public float time = 0.0f;
    private float scoreFromTime = 0.0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;            
        }

    }

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
        ScoreTxt.text = (score).ToString("N2"); // 현재 점수 + 시간에 따른 점수 업데이트
    }
}