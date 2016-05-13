using UnityEngine;
using System.Collections;

public class spawnCoins : MonoBehaviour {
    public GameObject coin;
    public int numCoins;
    Collider col;
    float startPoint;
	// Use this for initialization

    private void spawnLine()
    {
        for(int i =0; i < numCoins; ++i)
        {
            Instantiate(coin, new Vector3(0, 1 , startPoint + 2*i),  Quaternion.identity);
        }
    }

    private void spawnDiagnoal()
    {

    }
	void Start () {
        col = GetComponentInChildren<BoxCollider>();
        startPoint = transform.position.z- col.bounds.size.z/2;
        spawnLine();

    }
	
	// Update is called once per frame
	void Update () {
	    
	}
}
