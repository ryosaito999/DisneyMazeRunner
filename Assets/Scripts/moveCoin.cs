using UnityEngine;
using System.Collections;

public class moveCoin : MonoBehaviour {
    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Vector3 direction = new Vector3(0.0f, 0.0f, -1.0f);
        rb.velocity = direction * gameManager.speed;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Debug.Log("Add Score!");
            gameManager.coinTotal++;

            Destroy(this.gameObject);
        }
    }
}
