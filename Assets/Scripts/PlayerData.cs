using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float current_level;

    public PlayerData(PlayerBar PlayerBar)
    {
        current_level = PlayerBar.current_Level;
    }
}
