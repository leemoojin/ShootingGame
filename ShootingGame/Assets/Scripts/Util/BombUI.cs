using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombUI : MonoBehaviour
{
    public static BombUI instance;
    public GameObject[] ui_bombs;

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
    }

    public void BombCheck(int bombCount)
    {
        for (int i = 0; i < ui_bombs.Length; i++)
        {
            if (i + 1 <= bombCount)
            {
                ui_bombs[i].SetActive(true);
            }
            else
            {
                ui_bombs[i].SetActive(false);
            }
        }
    }
}
