using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameOverScreen : MonoBehaviour {
    public Button restartButton;

	// Use this for initialization
	void Start () {
        restartButton.onClick.AddListener( () => {
            //restart game
            Time.timeScale = 1;
            SceneManager.LoadScene("default");
        });  

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
