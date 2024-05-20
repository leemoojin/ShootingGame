using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : MonoBehaviour
{   
    //프리펩 생성
    public GameObject singleScoreBar;
    public GameObject multiScoreBar;
    public GameObject nullSingleScoreBar;
    public GameObject nullMultiScoreBar;

    public Transform content;


    // Start is called before the first frame update
    private void Start()
    {
        ShowScoreBar();

    }


    public void ShowScoreBar()
    {
        float maxHeight = 0;

        if (!RecordManager.IsMulti)
        {           

            //10위까지 생성
            Debug.Log($"Board.cs - ShowScoreBar() - 싱글 레코즈");            
            //레코즈에 있는 레코드갯수 만큼 스코어 바를 생성한다 - 프리펩 사용할것
            
            int count = Records.instance.singleRecords.Count;

            for (int i = 0; i < 10; i++)
            {
                float y = content.position.y + i * -220;
                maxHeight = y;

                if (count > 0)
                {
                    GameObject GOScoreBar = Instantiate(singleScoreBar, content);
                    
                    GOScoreBar.transform.position = new Vector2(content.position.x, y);
                    GOScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.singleRecords[i]);
                    count--;
                }
                else 
                {
                    GameObject GONullBar = Instantiate(nullSingleScoreBar, content);
                    GONullBar.transform.position = new Vector2(content.position.x, y);
                }
            }

            maxHeight = (maxHeight-530) * -1;
            content.GetComponent<RectTransform>().sizeDelta = new Vector2(content.GetComponent<RectTransform>().sizeDelta.x, maxHeight);            
        }
        else 
        {
            Debug.Log($"Board.cs - ShowScoreBar() - 멀티 레코즈 {Records.instance.multiRecords.Count}");

            int count = Records.instance.multiRecords.Count;
            for (int i = 0; i < 10; i++)
            {
                float y = content.position.y + i * -440;
                maxHeight = y;

                if (count > 0)
                {
                    GameObject GOScoreBar = Instantiate(multiScoreBar, content);

                    GOScoreBar.transform.position = new Vector2(content.position.x, y);
                    GOScoreBar.GetComponent<ScoreBar>().SetRecord(Records.instance.multiRecords[i]);
                    count--;
                }
                else
                {
                    GameObject GONullBar = Instantiate(nullMultiScoreBar, content);
                    GONullBar.transform.position = new Vector2(content.position.x, y);
                }
            }

            maxHeight = (maxHeight - 750) * -1;
            content.GetComponent<RectTransform>().sizeDelta = new Vector2(content.GetComponent<RectTransform>().sizeDelta.x, maxHeight);
        }

    }
}
