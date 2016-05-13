using UnityEngine;
using System.Collections;

public class removeGameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Tile")
        {
            gameManager.tileList.Remove(col.gameObject);
        }

        GameObject.Destroy(col.gameObject);
        
    }
}
