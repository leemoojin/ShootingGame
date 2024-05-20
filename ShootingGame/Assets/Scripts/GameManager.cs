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
        // PlayerPrefs에서 선택된 전투기 이미지 이름을 가져옴
        string SelectCharacter = PlayerPrefs.GetString("CharacterSelect");

        // 선택된 전투기 이미지를 Resources 폴더에서 로드
        Sprite fighterSprite = Resources.Load<Sprite>("SpaceShips/" + SelectCharacter);

        if (fighterSprite != null)
        {
            // 선택된 전투기 이미지를 UI Image 컴포넌트에 설정
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