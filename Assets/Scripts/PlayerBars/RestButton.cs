using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestButton : MonoBehaviour
{

    public GameObject hand;

    public void Rest()
    {
        bool isActive = hand.activeSelf;
        hand.SetActive(!isActive);
    }
}
