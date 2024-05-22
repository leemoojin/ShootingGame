using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesign : MonoBehaviour
{
    public Enemy smallPlane;
    public Enemy middlePlane;
    public Enemy largePlane;
    public Enemy bombPlane;
    public Enemy stone;
    public Enemy meteor;
    private ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    public void MakePlane()
    {
        Instantiate(smallPlane);
        if (scoreManager != null && scoreManager.TimeElapsed > 10)
        {
            Instantiate(middlePlane);
        }
        if (scoreManager != null && scoreManager.TimeElapsed > 20)
        {
            Instantiate(bombPlane);
        }
        if (scoreManager != null && scoreManager.TimeElapsed > 30)
        {
            Instantiate(stone);
        }
        if (scoreManager != null && scoreManager.TimeElapsed > 40)
        {
            Instantiate(largePlane);
        }
        if (scoreManager != null && scoreManager.TimeElapsed > 50)
        {
            Instantiate(meteor);
        }
        if (scoreManager != null && scoreManager.TimeElapsed > 60)
        {
            Instantiate(stone);
        }
    }
}