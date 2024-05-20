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
            // �ؽ�Ʈ Ȱ��/��Ȱ��ȭ �ݺ�
            Text.enabled = !Text.enabled;
            // ������ ���� ���� ���
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
