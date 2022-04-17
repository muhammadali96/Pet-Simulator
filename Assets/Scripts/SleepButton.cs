using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepButton : MonoBehaviour
{
    public PlayerBar PlayerBar;

    public void Sleep()
    {
        PlayerBar.current_Level--;
    }
}
