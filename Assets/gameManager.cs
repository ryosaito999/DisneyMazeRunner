using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

    //scoring
    public static float score;
    public static float speed = 7.0f;

    // Use this for initialization
    void Start () {
        score = 0;
    }

    // Update is called once per frame
    void Update () {
        score++;
    }
}
