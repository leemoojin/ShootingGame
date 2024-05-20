using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Board : MonoBehaviour
{   
    //������ ����
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

            //10������ ����
            Debug.Log($"Board.cs - ShowScoreBar() - �̱� ������");            
            //����� �ִ� ���ڵ尹�� ��ŭ ���ھ� �ٸ� �����Ѵ� - ������ ����Ұ�
            
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
            Debug.Log($"Board.cs - ShowScoreBar() - ��Ƽ ������ {Records.instance.multiRecords.Count}");

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
