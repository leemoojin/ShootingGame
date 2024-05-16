using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject smallPlane;
    public GameObject largePlane;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakePlane", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MakePlane()
    {
        Instantiate(smallPlane);
    }
}
