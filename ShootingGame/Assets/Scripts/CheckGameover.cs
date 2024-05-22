using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class CheckGameover : MonoBehaviour
{
    public HealthController healthPlayer1;
    public HealthController healthPlayer2;
    bool player1Dead, player2Dead;

    private void Update()
    {
        if (PlayerPrefs.HasKey("SelectedSpaceShip"))
        {
            GameObject Player1 = GameObject.FindGameObjectWithTag("Player1");

            if(Player1 != null)
            {
                healthPlayer1 = Player1.GetComponent<HealthController>();
            }
            
            if(healthPlayer1.currentHealth <= 0)
            {
                player1Dead = true;
            }
            if(player1Dead)
            {
                Debug.Log("게임오버");

                if (NewCharacterManager.Instance.spriteName == "PixelArtSpaceShipOne")
                {
                    GameOverRecord._instance.GetRecord(ScoreManager.Instance.totalScore, ScoreManager.Instance.playTime, 0);
                }
                else
                {
                    GameOverRecord._instance.GetRecord(ScoreManager.Instance.totalScore, ScoreManager.Instance.playTime, 1);
                }

                SceneManager.LoadScene("GameoverScene");                
            }
        }
        else
        {
            GameObject Player1 = GameObject.FindGameObjectWithTag("Player1");
            GameObject Player2 = GameObject.FindGameObjectWithTag("Player2");
            if(Player1 != null)
            {
                healthPlayer1 = Player1.GetComponent<HealthController>();
            }
            if(Player2 != null)
            {
                healthPlayer2 =Player2.GetComponent<HealthController>();
            }
            if(healthPlayer1.currentHealth <= 0)
            {
                player1Dead = true;
            }
            if(healthPlayer2.currentHealth <= 0)
            {
                player2Dead = true;
            }
            if(player1Dead && player2Dead)
            {
                Debug.Log("게임오버");
                SceneManager.LoadScene("GameoverScene");
            }
        }
    }
}

