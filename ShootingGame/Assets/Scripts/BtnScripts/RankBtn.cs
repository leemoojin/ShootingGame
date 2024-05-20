using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankBtn : MonoBehaviour
{
    public void Rank()
    {
        SceneManager.LoadScene("RecordScene");
    }
}
