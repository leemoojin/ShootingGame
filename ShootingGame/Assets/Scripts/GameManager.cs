using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Enemy smallPlane;
    public Enemy middlePlane;
    public Enemy largePlane;
    public Enemy bombPlane;
    public Enemy stone;
    public Enemy meteor;

    public GameObject Player1;
    public GameObject Player2;


    float time = 0.0f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakePlane", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void MakePlane()
    {
        if (time < 5)
        {
            Instantiate(smallPlane);
            Instantiate(bombPlane);
        }
        else if (time > 5 && time < 10)
        {
            Instantiate(middlePlane);
        }
        else if (time > 10 && time < 15)
        {
            Instantiate(largePlane);
        }
        else if (time > 15 && time < 20)
        {
            Instantiate(stone);
        }
        else if (time > 20 && time < 30)
        {
            Instantiate(meteor);
        }
    }
}