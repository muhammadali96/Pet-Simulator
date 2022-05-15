using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Video;

public class Timer : MonoBehaviour
{
    bool stopWatchActive = false;
    float currentTime;
    public Text currentTimeText;
    public GameObject EndPanel;
    public Text coins;
    public GameObject Animation;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(stopWatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
    }

    public void StartTimer()
    {
        stopWatchActive = true;
        Animation.gameObject.GetComponent<VideoPlayer>().Play();

    }

    public void StopTimer()
    {
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
        float coinsEarned = (int)(System.Math.Ceiling(currentTime / 10.0d) * 10);
        coins.text = "Congrats, you earned " + coinsEarned + " coins!";
        GameData.coins += coinsEarned;
        stopWatchActive = false;
        EndPanel.SetActive(true);
        Animation.gameObject.GetComponent<VideoPlayer>().Stop();
    }
}
