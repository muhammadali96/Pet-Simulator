using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveSystem 
{

    public static void SavePlayer (PlayerBar PlayerBar)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.cogshel";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(PlayerBar);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.cogshel";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        } else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }

    public static void ClearPlayer ()
    {
        string path = Application.persistentDataPath + "/player.cogshel";
        if (File.Exists(path))
        {
            File.Delete(path);
            Debug.Log("deleted");


        }
        else
        {
            Debug.LogError("Save file not found in " + path);
        }
    }
}
