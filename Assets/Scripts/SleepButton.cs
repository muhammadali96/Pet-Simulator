using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public EnergyFillStatusBar energyBar;

    public void Sleep()
    {
        energyBar.currentLevel--;
    }
}
