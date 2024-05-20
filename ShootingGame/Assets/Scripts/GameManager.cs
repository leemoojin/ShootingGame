using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Image SpaceShipImage;

    public Enemy smallPlane;
    public Enemy middlePlane;
    public Enemy largePlane;
    public Enemy bombPlane;
    public Enemy stone;
    public Enemy meteor;

    public GameObject Player1;
    public GameObject Player2;


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
        // PlayerPrefs���� ���õ� ������ �̹��� �̸��� ������
        string SelectCharacter = PlayerPrefs.GetString("CharacterSelect");

        // ���õ� ������ �̹����� Resources �������� �ε�
        Sprite fighterSprite = Resources.Load<Sprite>("SpaceShips/" + SelectCharacter);

        if (fighterSprite != null)
        {
            // ���õ� ������ �̹����� UI Image ������Ʈ�� ����
            SpaceShipImage.sprite = fighterSprite;
        }
        else
        {
            Debug.LogError("Selected fighter sprite not found");
        }
        InvokeRepeating("MakePlane", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    private void MakePlane()
    {
        Instantiate(smallPlane);
    }
}