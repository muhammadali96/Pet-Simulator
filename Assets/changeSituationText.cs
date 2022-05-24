using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeSituationText : MonoBehaviour
{
    public Text situationtext;

    public void selectPositive()
    {
        situationtext.text = "SITUATION:(NEGATIVE)";
    }
}
