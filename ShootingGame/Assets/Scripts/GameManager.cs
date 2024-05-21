using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Enemy smallPlane;
    public Enemy middlePlane;
    public Enemy largePlane;
    public Enemy bombPlane;
    public Enemy stone;
    public Enemy meteor;

    [SerializeField] private GameObject playerprefab1;
    [SerializeField] private GameObject playerprefab2;

    [SerializeField] private GameObject[] EnhanceAttack;
    public Vector3[] spawnPositions;

    public LevelDesign levelDesign;

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

        levelDesign.smallPlane = smallPlane;

        InvokeRepeating("MakePlane", 0f, 1f);   
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

    // Update is called once per frame
    void Update()
    {

    }

    private void MakePlane()
    {
        levelDesign.MakePlane();
    }

}