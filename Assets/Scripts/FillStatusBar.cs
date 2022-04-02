using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    public PlayerBar PlayerBar;
    public Image fillImage;
    private Slider slider;


    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerBar.max_Level == 0)
        {
            Debug.LogError("Max Level not set");
            return;
        }

        float fillValue = PlayerBar.current_Level / PlayerBar.max_Level;

        if(fillValue <= slider.maxValue / 3)
        {
            fillImage.color = Color.red;
        }
        else if(fillValue >= 2*slider.maxValue / 3 )
        {
            fillImage.color = new Color(0f, 0.2358491f, 0.02620547f);
        }
        else
        {
            fillImage.color = Color.yellow;
        }


        slider.value = fillValue;
    }
}
