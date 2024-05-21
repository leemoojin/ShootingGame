using UnityEngine;
using UnityEngine.UI;

public class BombAmountController : MonoBehaviour
{
    public int currentBombCount;
    [SerializeField] private int maximumBombCount;
    

    public void UseBomb(int bombCount)
    {
        if(currentBombCount == 0)
        {
            return;
        }
        currentBombCount -= bombCount;

        if(currentBombCount < 0)
        {
            currentBombCount = 0;
        }
    }

    public void AddBomb(int bombCount)
    {
        if(currentBombCount == maximumBombCount)
        {
            return;
        }

        currentBombCount += bombCount;
        if(currentBombCount > maximumBombCount)
        {
            currentBombCount = maximumBombCount;
        }
    }
    private void Start()
    {
       
    }
   
    // ÆøÅº °¹¼ö º¯°æ ¸Þ¼­µå
    public void SetBombCount(int bombCount)
    {
        currentBombCount = bombCount;
        
    }
}