using System.Collections.Generic;
using Unity.VisualScripting;

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
        //10위까지 기록
        if (!record.IsMulti)
        {
            if (singleRecords.Count == 0) singleRecords.Add(record);

            if (singleRecords.Count == 10)
            {
                if (singleRecords[9].Score1P > record.Score1P) return;
            }

            for (int i = 0; i < singleRecords.Count; i++)
            {
                //비교 후 record점수가 더 높을 경우
                if (record.Score1P > singleRecords[i].Score1P) singleRecords.Insert(i, record);
            }
            singleRecords.Add(record);

            if (singleRecords.Count == 11) singleRecords.RemoveAt(9);
        }
        else 
        {
            if (multiRecords.Count == 0) multiRecords.Add(record);

            if (multiRecords.Count == 10)
            {
                if (multiRecords[9].Score1P + multiRecords[9].Score2P > record.Score1P + record.Score2P) return;
            }

            for (int i = 0; i < multiRecords.Count; i++)
            {
                //비교 후 record점수가 더 높을 경우
                if (record.Score1P + record.Score2P  > multiRecords[i].Score1P + multiRecords[i].Score2P) multiRecords.Insert(i, record);
            }
            multiRecords.Add(record);

            if (multiRecords.Count == 11) multiRecords.RemoveAt(9);
        }
    }

    public int ObjectToIndex(Record record)
    {
        if (!record.IsMulti) return singleRecords.IndexOf(record);
        else return multiRecords.IndexOf(record);
    }

}