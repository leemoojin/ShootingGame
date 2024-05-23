using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using static UnityEngine.Mesh;

public class SaveLoadManager : MonoBehaviour
{
    private List<Record> singleRecords;
    private List<Record> multiRecords;

    public static SaveLoadManager Instance;
 
    private string folderName = "SaveLoadData";
    private string folderPath;
    private string _filePath1P;
    private string _filePath2P;

    private BinaryFormatter binaryFormatter = new BinaryFormatter();


    private void Awake()
    {
        //if (Instance == null)
        //{
        //    Instance = this;
        //}

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Debug.Log("SaveLoadManager.cs - Start()");


        folderPath = Path.Combine(Application.dataPath, folderName);

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
            Debug.Log("������ �����Ǿ����ϴ�: " + folderPath);
        }
        else
        {
            Debug.Log("������ �̹� �����մϴ�: " + folderPath);
        }

        _filePath1P = Path.Combine(folderPath, "singleRecords.dat");
        _filePath1P = Path.Combine(folderPath, "multiRecords.dat");

        LoadData();
        SaveData();

    }

    public void SaveData()
    {
        Debug.Log($"SaveLoadManager.cs - OnSave()");

        if (Records.instance.singleRecords.Count > 0)
        {
            List<Record> data = Records.instance.singleRecords;

            Debug.Log($"SaveLoadManager.cs - OnSave() - �̱� {data.Count}");

            try
            {
                using (Stream ws = new FileStream(_filePath1P, FileMode.Create))
                {
                    binaryFormatter.Serialize(ws, data);
                }
                Debug.Log($"SaveLoadManager.cs - OnSave() - ����");

            }
            catch (Exception e)
            {
                Debug.Log(e.ToString());
            }
        }

        if (Records.instance.multiRecords.Count > 0)
        {
            List<Record> data = Records.instance.multiRecords;

            Debug.Log($"SaveLoadManager.cs - OnSave() - ��Ƽ {data.Count}");

            try
            {
                using (Stream ws = new FileStream(_filePath2P, FileMode.Create))
                {
                    binaryFormatter.Serialize(ws, data);
                }
                Debug.Log($"SaveLoadManager.cs - OnSave() - ����");

            }
            catch (Exception e)
            {
                Debug.Log(e.ToString());
            }
        }
    }


    public void LoadData()
    {
        Debug.Log($"SaveLoadManager.cs - LoadData()");
       

        try
        {
            List<Record> _loadData = null;
            using (Stream rs = new FileStream(_filePath1P, FileMode.Open))
            {
                _loadData = (List<Record>)binaryFormatter.Deserialize(rs);
            }

            if (_loadData.Count > 0)
            {
                Records.instance.singleRecords = _loadData;                

            }

        }
        catch (Exception)
        {
            Debug.Log("���� ����");            
        }


        try
        {
            List<Record> _loadData2 = null;

            using (Stream rs = new FileStream(_filePath2P, FileMode.Open))
            {
                _loadData2 = (List<Record>)binaryFormatter.Deserialize(rs);
            }

            if (_loadData2.Count > 0)
            {
                Records.instance.singleRecords = _loadData2;
                Debug.Log($"SaveLoadManager.cs - OnLoad() - ��Ƽ �ε�");

            }
        }
        catch (Exception)
        {
            Debug.Log("���� ����");
        }
        
    }

}
