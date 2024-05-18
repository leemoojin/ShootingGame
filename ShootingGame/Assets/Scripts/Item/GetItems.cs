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
        Debug.Log("현재 점수 :" +player1Stat.Score);
        Debug.Log("현재 체력 :" + player1Stat.Health);
        Debug.Log("현재 폭탄 개수:"+player1Stat.BombCount);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            switch (itemData.setItemType)
            {
                case ItemData.ItemType.Bomb:
                player1Stat.BombCount++;
                    
                    Debug.Log("폭탄 개수 증가, 현재 폭탄 개수 :" + player1Stat.BombCount);
                    break;
                
                case ItemData.ItemType.EnhanceAttack:
                    //TODO : 공격 강화 먹었을 때
                    Debug.Log("공격 강화");
                break;
                
                case ItemData.ItemType.IncreaseScore:
                    //TODO : 점수 획득 증가
                    Debug.Log("일정 시간 점수 획득 증가");
                    break;
                
                case ItemData.ItemType.Coin:
                    player1Stat.Score++;
                    player1Stat.CurrentScore += player1Stat.Score;
                    Debug.Log("점수 증가, 현재 점수 :" + player1Stat.CurrentScore);
                   break;
                
                case ItemData.ItemType.Shield:
                    //TODO: 쉴드
                    Debug.Log("쉴드 생성");
                    break;
                
                case ItemData.ItemType.HP:
                    Debug.Log("체력 증가, 현재 체력 :" + player1Stat.Health);
                    break;

            }

            Destroy(gameObject);
        }
    }
}
