using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleBtn : MonoBehaviour
{
    public void Single()
    {
        SceneManager.LoadScene("SingleScene");
    }
}
