using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDesign : MonoBehaviour
{
    public Enemy smallPlane;
    public void MakePlane()
    {
        Instantiate(smallPlane);
    }
}
