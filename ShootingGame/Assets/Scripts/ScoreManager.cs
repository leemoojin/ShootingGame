using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text timeTxt;
    public Text scoreTxt;

    private int score;
    private float timeElapsed = 0.0f;


    public LevelDesign levelDesignPrefab;

    private LevelDesign levelDesign;

    private void Start()
    {
        levelDesign = Instantiate(levelDesignPrefab);
        levelDesign.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;  // 경과 시간 누적
        timeTxt.text = timeElapsed.ToString("N2");
        UpdateScoreText();
    }

    public void AddScore(float value)
    {
        score += (int)value;
        UpdateScoreText();
        Debug.Log($"점수 추가: {value}. 현재 점수: {score}");
    }

    private void UpdateScoreText()
    {
        scoreTxt.text = ((int)(score + timeElapsed)).ToString();  // 총 점수 계산
    }

    // 시간 값을 반환하는 프로퍼티
    public float TimeElapsed
    {
        get { return timeElapsed; }
    }
}