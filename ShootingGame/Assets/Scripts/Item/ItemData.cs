using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData",menuName ="ScriptableObjects/ItemData" ,order = 2)]
public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite itemSprite;
    public bool isIncreaseScore;


    public int giveScore = 15;

    public enum ItemType
    {
        Bomb,
        EnhanceAttack,
        IncreaseScore,
        Coin,
        Shield,
        HP
    }

    public ItemType setItemType; //아이템 타입을 저장하는 변수
}
