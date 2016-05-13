using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

    public static List<GameObject> tileList = new List<GameObject>();
    public static bool gameOver = false;
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
        tileList.Add(startTile);
        tileList.Add(nextTile);
        direction = new Vector3(0.0f, 0.0f, -1.0f);

    }

    // Update is called once per frame
    void Update () {
        score++;

        for(int i =0; i < tileList.Count; ++i)
        {
            tileList[i].GetComponent<Rigidbody>().velocity = direction * gameManager.speed;

        }

      
    }
}
