using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SadnessController : MonoBehaviour
{
    private bool isHungry = false;
    private bool isBadMood = false;
    private bool isTired = false;

    

    public void setHungry(bool value)
    {
        isHungry = value;
        updateAnim();
    }

    public void setIsBadMood(bool value)
    {
        isBadMood = value;
        updateAnim();
    }

    public void setIsTired(bool value)
    {
        isTired = value;
        updateAnim();
    }

    public void updateAnim()
    {
        this.GetComponent<Animator>().SetBool("Sad", isHungry || isTired || isBadMood);
        
    }
}
