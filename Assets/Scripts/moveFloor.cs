using UnityEngine;
using System.Collections;

public class moveFloor : MonoBehaviour {

    GameObject floor;

    public GameObject NoWallTile;
    public GameObject LWallTile;
    public GameObject RWallTile;


    Vector3 colBounds;
    Vector3 colCenter;

    Collider col;
    Rigidbody rb;
    float tileSize;

    GameObject futureTile; 

    private GameObject findFloor(GameObject gameobject)
    {
        return gameobject.transform.FindChild("Floor").gameObject;
    }

    private GameObject randomTile()
    {
        int x = Random.Range(0, 4);
        switch (x)
        {
            

            case 0:
                return LWallTile;
                break;
            case 1:
                return RWallTile;
                break;
            default:
                return NoWallTile;
                break;
        }

      
    }

    private void spawnNextTile()
    {
        Debug.Log(colBounds.z);

        //spawn a tile
        // feel like I could do this slightly better?
        futureTile = randomTile();
        //Instantiate(futureTile, new Vector3(0,0, nextTileLength)

        float moveAreaZ = gameObject.GetComponent<Renderer>().bounds.size.z+ futureTile.GetComponent<Renderer>().bounds.size.z ;
        Vector3 center = gameObject.GetComponent<Renderer>().bounds.center;
        
        Instantiate(futureTile, new Vector3(0, 0, center.z + 48), Quaternion.identity);

    }

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        Vector3 direction = new Vector3(0.0f, 0.0f, -1.0f);
        GetComponent<Rigidbody>().velocity = direction * gameManager.speed;
    }

    // Update is called once per frame
    void Update () {

      
    
        
    }

    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0.0f, 0.0f, -1.0f);
        rb.velocity = direction * gameManager.speed;

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
