using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class GeneratePrefab : MonoBehaviour
{
    [SerializeField] private GameObject playerprefab1;
    [SerializeField] private GameObject playerprefab2;
    //[SerializeField] private GameObject Coin;
    [SerializeField] private GameObject HP;
    [SerializeField] private GameObject[] EnhanceAttack;
    [SerializeField] private GameObject Bomb;
    [SerializeField] private GameObject Shield;
    //[SerializeField] private GameObject IncreaseScore;
    public Vector3[] spawnPositions;


    private void Start()
    {

        if (ButtonClicked()) // 만약 버튼이 클릭되었다면
        {
            // 플레이어 1 프리팹 생성
            var player1 = PlayerInput.Instantiate(playerprefab1, controlScheme: "Player1", pairWithDevices: new InputDevice[] { Keyboard.current });
            player1.transform.position = new Vector3(5.5f, -4f, 0);
        }

        else
        {
            var player2 = PlayerInput.Instantiate(playerprefab2, controlScheme: "Player2", pairWithDevices: new InputDevice[] { Keyboard.current });
            player2.transform.position = new Vector3(-5.5f, -4f, 0);
        }

        //var coin = GameObject.Instantiate(Coin);
        //coin.transform.position = new Vector3(-7.2f, 2, 0);

        var bomb = GameObject.Instantiate(Bomb);
        bomb.transform.position = new Vector3(7.2f, 2, 0);

        //var shield = GameObject.Instantiate(Shield);
        //shield.transform.position = new Vector3(-5f,2,0);

        var hp = GameObject.Instantiate(HP);
        hp.transform.position = new Vector3(5f, 2, 0);

        SpawnEnhancedAttacks();

        var shield = GameObject.Instantiate(Shield);
        shield.transform.position = new Vector3(0, 2.54f, 0);

    }

    private void SpawnEnhancedAttacks()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            Instantiate(EnhanceAttack[i % EnhanceAttack.Length], spawnPositions[i], Quaternion.identity);

        }
    }

    private bool ButtonClicked()
    {
        return PlayerPrefs.HasKey("SelectedSpaceShip");
    }
}
