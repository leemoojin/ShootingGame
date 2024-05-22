using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text timeTxt;  // �빮�� ������ �ҹ��ڷ� �����ϴ� ���� ����
    public Text scoreTxt;

    private int score;
    private float timeElapsed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;  // ��� �ð� ����
        timeTxt.text = timeElapsed.ToString("N2");
        UpdateScoreText();
    }

    public void AddScore(float value)
    {
        score += (int)value;
        UpdateScoreText();
        Debug.Log($"���� �߰�: {value}. ���� ����: {score}");
    }

    private void UpdateScoreText()
    {
        scoreTxt.text = ((int)(score + timeElapsed)).ToString();  // �� ���� ���
    }

    // �ð� ���� ��ȯ�ϴ� ������Ƽ
    public float TimeElapsed
    {
        get { return timeElapsed; }
    }
}