using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Records
{
    public List<Record> singleRecords = new List<Record>();
    public List<Record> multiRecords = new List<Record>();

    public static Records instance = new Records();

    public Records()
    {
        if (instance == null) instance = this;  

    }

    public void AddRecord(Record record)
    {
        Debug.Log($"Records.cs - AddRecord() - 값추가 {record.IsMulti}, 기록 : {record.Score1P}");

        //10위까지 기록
        if (!record.IsMulti)
        {
            int count = singleRecords.Count;

            if (count == 0)
            {
                Debug.Log($"Records.cs - AddRecord() - singleRecords.Count 0 개");
                singleRecords.Add(record);
                return;
            }

            if (count == 10)
            {
                if (singleRecords[9].Score1P > record.Score1P) return;
            }

            for (int i = 0; i < count; i++)
            {
                if (record.Score1P > singleRecords[i].Score1P)
                {
                    Debug.Log($"Records.cs - AddRecord() - 새로 들어온 값이 더 큼 {record.Score1P} > {singleRecords[i].Score1P}, {i}");                    
                    singleRecords.Insert(i, record);
                    break;
                }
                else 
                {
                    Debug.Log($"Records.cs - AddRecord() - 새로 들어온 값이 작음 {record.Score1P} <= {singleRecords[i].Score1P}, {i}");                    
                }
            }

            if (singleRecords.Count == count) singleRecords.Add(record);

            if (singleRecords.Count == 11) singleRecords.RemoveAt(9);
        }
        else
        {
            int count = multiRecords.Count;

            if (count == 0)
            {
                Debug.Log($"Records.cs - AddRecord() - multiRecords.Count 0 개");
                multiRecords.Add(record);
                return;
            }

            if (count == 10)
            {
                if (multiRecords[9].Score1P + multiRecords[9].Score2P > record.Score1P + record.Score2P) return;
            }

            for (int i = 0; i < count; i++)
            {
                if (record.Score1P + record.Score2P > multiRecords[i].Score1P + multiRecords[i].Score2P)
                {
                    Debug.Log($"Records.cs - AddRecord() - 새로 들어온 값이 더 큼");
                    multiRecords.Insert(i, record);
                    break;
                }
                else
                {
                    Debug.Log($"Records.cs - AddRecord() - 새로 들어온 값이 작음");                    
                }
            }

            if (multiRecords.Count == count) multiRecords.Add(record);

            if (multiRecords.Count == 11) multiRecords.RemoveAt(9);

        }
    }

    public int ObjectToIndex(Record record)
    {
        if (!record.IsMulti) return singleRecords.IndexOf(record);
        else return multiRecords.IndexOf(record);
    }

}