using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{
    public static void SaveMoney(Money cash)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/prime1.game";
        FileStream stream= new FileStream(path, FileMode.Create);
        MoneyData data = new MoneyData(cash);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static MoneyData LoadSystem()
    {
        string path= Application.persistentDataPath + "/prime1.game";
        if (File.Exists(path))
        {
            BinaryFormatter formatter= new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            MoneyData data= formatter.Deserialize(stream) as MoneyData;
            stream.Close();
            return data;

        }
        else
        {
            Debug.LogError("The File does not exist in this Path:" + path);
            return null;
        }
    }
    
}
