using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int Health {  get; set; }
    public int BombCount { get; set; }
    public int Score { get; set; }
    public int CurrentScore { get; set; }
    public bool HasShield { get; set; }
    public int EnhancedAttack { get; set; }

    public PlayerStatus()
    {
        Health = 3;
        BombCount = 0;
        Score = 0;
        HasShield = false;
    }

}

public class PlayerHP : PlayerStatus 
{
    PlayerStatus ps;

    private void Awake()
    {
        
        ps = GetComponent<PlayerStatus>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            ps.Health--;
        }
    }
}

public class PlayerScore : PlayerStatus
{
    PlayerStatus ps;
    private void Awake()
    {
        ps = GetComponent<PlayerStatus>();
    }

    public void GetScore()
    {
        ps.CurrentScore = Score;
    }
}

