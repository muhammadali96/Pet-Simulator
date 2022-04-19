using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float energyLevel;
    public float hungerLevel;
    public float moodLevel;

    public PlayerData(float givenEnergyLevel, float givenHungerLevel, float givenMoodLevel)
    {
        energyLevel = givenEnergyLevel;
        hungerLevel = givenHungerLevel;
        moodLevel = givenMoodLevel;
    }

    public void Display()
    {
        Debug.LogFormat("e:{0}, h:{1}, m:{2}", energyLevel, hungerLevel, moodLevel);
    }
}
