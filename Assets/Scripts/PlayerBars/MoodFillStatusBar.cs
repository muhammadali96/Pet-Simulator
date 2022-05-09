using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoodFillStatusBar : MonoBehaviour
{
    //public EnergyBar energyBar;
    public Image fillImage;
    private Slider slider;
    public float currentLevel;
    public float maxLevel;
    public int DelayAmount = 1;
    public GameObject playerAnim;

    protected float timer;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerData data = SaveSystem.LoadPlayer();

        //currentLevel = data.currentLevel;
    }

    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
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
        if (maxLevel == 0)
        {
            Debug.LogError("Max Level not set");
            return;
        }

        float fillValue = currentLevel / maxLevel;

        if(fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.red;
            playerAnim.GetComponent<Animator>().SetBool("Sad", true);
        }
        else if(fillValue >= 2*slider.maxValue / 3 )
        {
            fillImage.color = new Color(0f, 0.2358491f, 0.02620547f);
            playerAnim.GetComponent<Animator>().SetBool("Sad", false);
        }
        else
        {
            fillImage.color = Color.yellow;
            playerAnim.GetComponent<Animator>().SetBool("Sad", false);
        }


        slider.value = fillValue;
    }
}
