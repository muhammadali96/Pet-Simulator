using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodBar : MonoBehaviour
{
    public float currentLevel;
    public float maxLevel;
    public int DelayAmount = 1;

    protected float timer;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerData data = SaveSystem.LoadPlayer();

        //currentLevel = data.currentLevel;
    }

    //this is saving too many times
    // Update is called once per frame
    void Update()
    {
        //SaveSystem.SavePlayer(this);
        timer += Time.deltaTime;

        if (timer >= DelayAmount)
        {
            timer = 0f;
            currentLevel--;
        }

    }
}

