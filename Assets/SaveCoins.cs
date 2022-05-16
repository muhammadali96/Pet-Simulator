using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveCoins : MonoBehaviour
{
    public Text CoinsTXT;

    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = GameData.coins.ToString();
    }

}
