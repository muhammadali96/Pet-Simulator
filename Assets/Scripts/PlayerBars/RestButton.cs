using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestButton : MonoBehaviour
{
    public EnergyBar energyBar;

    public void Sleep()
    {
        energyBar.currentLevel--;
    }
}
