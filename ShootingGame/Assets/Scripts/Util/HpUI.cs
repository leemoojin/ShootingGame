using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUI : MonoBehaviour
{
    public static HpUI instance;
    public GameObject[] ui_hp;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void HpCheck(int hpCount)
    {
        for (int i = 0; i < ui_hp.Length; i++)
        {
            if (i + 1 <= hpCount)
            {
                ui_hp[i].SetActive(true);
            }
            else
            {
                ui_hp[i].SetActive(false);
            }
        }
    }
}
