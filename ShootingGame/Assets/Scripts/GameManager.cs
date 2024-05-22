using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject playerprefab1;
    [SerializeField] private GameObject playerprefab2;

    [SerializeField] private GameObject[] EnhanceAttack;
    public Vector3[] spawnPositions;

    private LevelDesign levelDesign;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        levelDesign = GetComponent<LevelDesign>();

        InvokeRepeating("MakePlane", 0f, 2f);   
        if (PlayerPrefs.HasKey("SelectedSpaceShip")) // 만약 버튼이 클릭되었다면
        {
            // 플레이어 1 프리팹 생성
            var player1 = PlayerInput.Instantiate(playerprefab1, controlScheme: "Player1", pairWithDevices: new InputDevice[] { Keyboard.current });
            player1.transform.position = new Vector3(0, -4.4f, 0);
        }
        else
        {
            // 플레이어 1 프리팹 생성 (조건 만족하지 않음)
            var player2 = PlayerInput.Instantiate(playerprefab1, controlScheme: "Player1", pairWithDevices: new InputDevice[] { Keyboard.current });
            player2.transform.position = new Vector3(-5.5f, -4f, 0);
        }

        
    }


    private void MakePlane()
    {
        levelDesign.MakePlane();
    }

}