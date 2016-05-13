using UnityEngine;
using System.Collections;

public class moveFloor : MonoBehaviour {

    public GameObject tile;
    public GameObject floor;

    public float speed;
    Vector3 colBounds;
    Vector3 colCenter;

    Collider col;
    Rigidbody rb;
    float tileSize;

    public GameObject futureTile; 
    
    

    private void spawnNextTile()
    {
        Debug.Log(colBounds.z);

        //spawn a tile
        float futurelocation = futureTile.GetComponentInChildren<BoxCollider>().bounds.size.z + colBounds.z + transform.position.z;
        Instantiate(tile, new Vector3(transform.position.x, transform.position.y , futurelocation+1.0f), Quaternion.identity);

        //set up next tile to spawn
        futureTile = tile;
    }

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        col = GetComponentInChildren<Collider>();
        colBounds = floor.GetComponent<BoxCollider>().bounds.size;
    }

    // Update is called once per frame
    void Update () {

    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0.0f, 0.0f, -1.0f);
        rb.velocity = direction * speed;

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Hit next tile!");
            spawnNextTile();
        }
    }
}
