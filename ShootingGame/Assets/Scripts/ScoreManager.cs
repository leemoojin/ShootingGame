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
        scoreFromTime = time; // �ð��� ���� ���� ���
        TimeTxt.text = time.ToString("N2");
        UpdateScoreText();
    }

    public void AddScore(float value)
    {
        score += (int)value;
        UpdateScoreText(); // ���� ������Ʈ
    }

    private void UpdateScoreText()
    {
        ScoreTxt.text = (score + scoreFromTime).ToString("N2"); // ���� ���� + �ð��� ���� ���� ������Ʈ
    }
}