using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

    public static List<GameObject> tileList;
    public static bool gameOver ;
    Vector3 direction;
    //scoring
    public static float score;
    public static float coinTotal;
    public static float speed = 10.0f;

    public GameObject startTile;
    public GameObject nextTile;

    // Use this for initialization
    void Start () {
        score = 0;
        direction = new Vector3(0.0f, 0.0f, -1.0f);

        gameOver = false;
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update () {
        score++;


      
    }
}
