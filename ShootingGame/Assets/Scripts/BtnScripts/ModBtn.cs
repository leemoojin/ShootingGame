using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModBtn : MonoBehaviour
{
    public void Mod()
    {
        SceneManager.LoadScene("PlayerChoiceScene");
    }
}
