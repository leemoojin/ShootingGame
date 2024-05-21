using UnityEngine;
using UnityEngine.UI;

public class BombAmountController : MonoBehaviour
{
    public int currentBombCount;
    [SerializeField] private int maximumBombCount;
    public Image[] bombImages; // 폭탄 이미지 배열

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
        UpdateBombImages(); // 초기화할 때 UI 이미지 업데이트
    }
    private void UpdateBombImages()
    {
        for (int i = 0; i < maximumBombCount; i++)
        {
            // 현재 폭탄 갯수에 따라 이미지 활성화/비활성화
            if (i < currentBombCount)
            {
                bombImages[i].enabled = true; // 활성화
            }
            else
            {
                bombImages[i].enabled = false; // 비활성화
            }
        }
    }
    // 폭탄 갯수 변경 메서드
    public void SetBombCount(int bombCount)
    {
        currentBombCount = bombCount;
        UpdateBombImages(); // 변경 후 UI 이미지 업데이트
    }
}