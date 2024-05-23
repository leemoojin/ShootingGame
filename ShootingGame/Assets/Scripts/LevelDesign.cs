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
        InvokeRepeating("MakePlane", 0f, 2f);
    }

    public void MakePlane()
    {
        Instantiate(smallPlane);
        if (scoreManager == null) return;

        float timeElapsed = scoreManager.TimeElapsed;

        if (timeElapsed > 10) Instantiate(middlePlane);
        if (timeElapsed > 20) Instantiate(bombPlane);
        if (timeElapsed > 30) Instantiate(stone);
        if (timeElapsed > 40) Instantiate(largePlane);
        if (timeElapsed > 50) Instantiate(meteor);
    }
}