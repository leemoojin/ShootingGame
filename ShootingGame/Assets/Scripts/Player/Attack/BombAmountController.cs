using UnityEngine;
using UnityEngine.UI;

public class BombAmountController : MonoBehaviour
{
    public int currentBombCount;
    [SerializeField] private int maximumBombCount;
    public Image[] bombImages; // ��ź �̹��� �迭

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
        UpdateBombImages(); // �ʱ�ȭ�� �� UI �̹��� ������Ʈ
    }
    private void UpdateBombImages()
    {
        for (int i = 0; i < maximumBombCount; i++)
        {
            // ���� ��ź ������ ���� �̹��� Ȱ��ȭ/��Ȱ��ȭ
            if (i < currentBombCount)
            {
                bombImages[i].enabled = true; // Ȱ��ȭ
            }
            else
            {
                bombImages[i].enabled = false; // ��Ȱ��ȭ
            }
        }
    }
    // ��ź ���� ���� �޼���
    public void SetBombCount(int bombCount)
    {
        currentBombCount = bombCount;
        UpdateBombImages(); // ���� �� UI �̹��� ������Ʈ
    }
}