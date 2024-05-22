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

    public int totalScore;
    public string playTime;


    public LevelDesign levelDesignPrefab;

    private LevelDesign levelDesign;

    public static ScoreManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        levelDesign = Instantiate(levelDesignPrefab);
        levelDesign.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;  // ��� �ð� ����
        playTime = timeElapsed.ToString("N2");
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
        totalScore = (int)(score + timeElapsed);
        scoreTxt.text = ((int)(score + timeElapsed)).ToString();  // �� ���� ���
    }

    // �ð� ���� ��ȯ�ϴ� ������Ƽ
    public float TimeElapsed
    {
        get { return timeElapsed; }
    }
}