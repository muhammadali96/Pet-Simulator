using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine;

public static class SaveSystem 
{

    public static void SaveGameState () //Energy, hunger, mood
    {
        GameObject tiger = GameObject.Find("Tiger");
        EnergyBar energyBar = tiger.GetComponent<EnergyBar>();
        float energyLevel = energyBar.currentLevel;

        HungerBar hungerBar = tiger.GetComponent<HungerBar>();
        float hungerLevel = hungerBar.currentLevel;

        MoodBar moodBar = tiger.GetComponent<MoodBar>();
        float moodLevel = moodBar.currentLevel;
        
        
        //find tiger in scene
        //get energy bar componenet from tiger
        //access current level public variable in energy bar
        //
        //do same for hunger and mood
        //
        //save energy, hunger and mood to disk


        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.cogshel";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(energyLevel, hungerLevel, moodLevel);
        Debug.Log("Game saved");
        data.Display();
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerData LoadGameState ()
    {
        string path = Application.persistentDataPath + "/player.cogshel";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            Debug.Log("Game Loaded");
            data.Display();
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
