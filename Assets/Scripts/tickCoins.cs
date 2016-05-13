using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class tickCoins : MonoBehaviour {
    Text coinText;

    // Use this for initialization
    void Start () {
        coinText = GetComponent<Text>();

    }
	
	// Update is called once per frame
	void Update () {
        coinText.text = "Coins: " + gameManager.coinTotal.ToString();
    }
}
