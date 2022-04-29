using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestButton : MonoBehaviour
{
    public EnergyFillStatusBar energyBar;

    public void Rest()
    {
        energyBar.currentLevel++;
    }
}
