using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clampBreathe : MonoBehaviour
{
    public Button breatheButton;

    // Update is called once per frame
    void Update()
    {
        Vector3 breathePos = Camera.main.WorldToScreenPoint(this.transform.position);
        breatheButton.transform.position = breathePos;
    }
}
