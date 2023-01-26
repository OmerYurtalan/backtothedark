using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter=new BinaryFormatter();
        FileStream stream=new FileStream("player.bin",FileMode.Create);

        formatter.Serialize(stream, Veriler.name);
        stream.Close();
    }

    public static void LoadPlayer()
    {
        if(File.Exists("player.bin"))
        {
            Debug.Log("Dosyaya girildi!!");
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream("player.bin", FileMode.Open);

            Veriler.name=(string)formatter.Deserialize(stream);
            stream.Close();
        }
        else
        {
            Debug.Log("Dosya Yok!!!!");
        }
        
    }
}
