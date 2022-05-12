using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestButton : MonoBehaviour
{
    public EnergyFillStatusBar energyBar;
    public GameObject objectToAnimate;

    public void Rest()
    {
        energyBar.currentLevel++;
        objectToAnimate.GetComponent<Animator>().SetTrigger("Sleeping");
    }
}
