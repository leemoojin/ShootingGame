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
            // 텍스트 활성/비활성화 반복
            pressAnyKeyText.enabled = !pressAnyKeyText.enabled;
            // 지정된 간격 동안 대기
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
