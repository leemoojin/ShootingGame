using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject smallPlane;
    public GameObject middlePlane;
    public GameObject largePlane;
    public Enemy bombPlane;

    public GameObject Player;


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
        Instantiate(smallPlane);

        if(time > 5f)
        {
            Enemy bomb = Instantiate(bombPlane);
            bomb.Player = Player;
        }

    }
}
