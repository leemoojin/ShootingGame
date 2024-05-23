using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetBtn : MonoBehaviour
{
    public static SetBtn Instance 
    { 
        get; 
        set;
    }
    public GameObject settingPanelPrefab;
    private GameObject settingPanelInstance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // �� ��ȯ �� �ı����� �ʰ� ����
        }
        else
        {
            Destroy(gameObject); 
        }
    }
    public void OpenOptions()
    {
        if (settingPanelInstance == null)
        {
            Canvas canvas = FindObjectOfType<Canvas>();
            if (canvas != null)
            {
                settingPanelInstance = Instantiate(settingPanelPrefab, canvas.transform);
            }
            else
            {
                Debug.LogError("Canvas not found in the scene.");
                return;
            }
        }
        settingPanelInstance.SetActive(true);
    }

    public void CloseOptions()
    {
        if (settingPanelInstance != null)
        {
            settingPanelInstance.SetActive(false);
        }
    }
}
