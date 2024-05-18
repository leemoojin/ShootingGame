using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    public ItemData itemData;
    public PlayerStatus player1Stat { get; set; }
    public PlayerStatus player2Stat { get; set; }
   
    private void Awake()
    {
        player1Stat = new PlayerStatus();
        player2Stat = new PlayerStatus();
        player1Stat = GetComponent<PlayerStatus>();
        player2Stat = GetComponent<PlayerStatus>();
        itemData = ScriptableObject.CreateInstance<ItemData>();
        Debug.Log("���� ���� :" +player1Stat.Score);
        Debug.Log("���� ü�� :" + player1Stat.Health);
        Debug.Log("���� ��ź ����:"+player1Stat.BombCount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            switch (itemData.setItemType)
            {
                case ItemData.ItemType.Bomb:
                player1Stat.BombCount++;
                    
                    Debug.Log("��ź ���� ����, ���� ��ź ���� :" + player1Stat.BombCount);
                    break;
                
                case ItemData.ItemType.EnhanceAttack:
                    //TODO : ���� ��ȭ �Ծ��� ��
                    Debug.Log("���� ��ȭ");
                break;
                
                case ItemData.ItemType.IncreaseScore:
                    //TODO : ���� ȹ�� ����
                    Debug.Log("���� �ð� ���� ȹ�� ����");
                    break;
                
                case ItemData.ItemType.Coin:
                    player1Stat.Score++;
                    player1Stat.CurrentScore += player1Stat.Score;
                    Debug.Log("���� ����, ���� ���� :" + player1Stat.CurrentScore);
                   break;
                
                case ItemData.ItemType.Shield:
                    //TODO: ����
                    Debug.Log("���� ����");
                    break;
                
                case ItemData.ItemType.HP:
                    Debug.Log("ü�� ����, ���� ü�� :" + player1Stat.Health);
                    break;

            }

            Destroy(gameObject);
        }
    }
}
