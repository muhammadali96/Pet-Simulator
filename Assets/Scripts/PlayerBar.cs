using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBar : MonoBehaviour
{
    public float current_Level;
    public float max_Level;
    public int DelayAmount = 1;

    protected float Timer;

    public void SavePlayer ()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        current_Level = data.current_level;
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        SavePlayer();
        Timer += Time.deltaTime;

        if (Timer >= DelayAmount)
        {
            Timer = 0f;
            current_Level--;
        }
            
    }
}
