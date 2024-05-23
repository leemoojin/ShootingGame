using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnhaceAttackController : MonoBehaviour
{
    public int currentBulletLine;
    [SerializeField] private int maxBulletLine = 4;
    [SerializeField] private int minBulletLine = 1;
   

    public void reduceBulletLine(int bulletLine)
    {
       if(currentBulletLine == minBulletLine)
        {
            return;
        }
       currentBulletLine -= bulletLine;
    }

    public void AddBulletLine(int bulletLine)
    {
        if(currentBulletLine == maxBulletLine)
        {
            return;
        }
        currentBulletLine += bulletLine;
    }
}
