using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public Text pressAnyKeyText;
    [SerializeField] private float blinkInterval = 0.5f;

    private string currentSceneName;
    void Start()
    {
        StartCoroutine(BlinkText());
        currentSceneName = SceneManager.GetActiveScene().name;
        Debug.Log($"IntroController - {currentSceneName}");
    }

    void Update()
    {
        
        if (Input.anyKeyDown)
        {
            
            SceneManager.LoadScene("MenuScene");

       
        }
    }
    IEnumerator BlinkText()
    {
        while (true)
        {
            // �ؽ�Ʈ Ȱ��/��Ȱ��ȭ �ݺ�
            pressAnyKeyText.enabled = !pressAnyKeyText.enabled;
            // ������ ���� ���� ���
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
