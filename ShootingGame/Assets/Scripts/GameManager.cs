using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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

    public Text TimeTxt;
    public Text ScoreTxt;

    int score;

    float time = 0.0f;

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
        InvokeRepeating("MakePlane", 0f, 1f);

        var player1 = PlayerInput.Instantiate(playerprefab1, controlScheme: "Player1", pairWithDevices: new InputDevice[] { Keyboard.current });
        var player2 = PlayerInput.Instantiate(playerprefab2, controlScheme: "Player2", pairWithDevices: new InputDevice[] { Keyboard.current });

        player1.transform.position = new Vector3(1f, -4f, 0);
        player2.transform.position = new Vector3(-1f, -4f, 0);

        SpawnEnhancedAttacks();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        TimeTxt.text = time.ToString("N2");
    }

    public void AddScore(float value)
    {
        score += (int)value;
        ScoreTxt.text = score.ToString();
    }

    private void MakePlane()
    {
        Instantiate(smallPlane);
    }

    private void SpawnEnhancedAttacks()
    {
        for (int i = 0; i < spawnPositions.Length; i++)
        {
            Instantiate(EnhanceAttack[i % EnhanceAttack.Length], spawnPositions[i], Quaternion.identity);

        }
    }
}