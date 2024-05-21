using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text Text;
    [SerializeField] private float blinkInterval = 0.5f;

    void Start()
    {
        StartCoroutine(BlinkText());
    }
    IEnumerator BlinkText()
    {
        while (true)
        {
            // 텍스트 활성/비활성화 반복
            Text.enabled = !Text.enabled;
            // 지정된 간격 동안 대기
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
