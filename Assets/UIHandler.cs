using UnityEngine;
using System.Collections;

public class UIHandler : MonoBehaviour {

    public GameObject GUI;
    public GameObject gameoverMenu;

	// Use this for initialization
	void Start () { 
        GUI.SetActive(true);
        gameoverMenu.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
	    if(gameManager.gameOver)
        {
            //
            Time.timeScale = 0;


            // show game over yeaaa
            GUI.SetActive(false);
            gameoverMenu.SetActive( true);
        }
	}
}
