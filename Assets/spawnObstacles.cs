using UnityEngine;
using System.Collections;

public class spawnObstacles : MonoBehaviour {

    int patterns;
    float tileSizeX;
    float tileSizeZ;
    Vector3 center;

    public GameObject floor;
    public GameObject obstacle;
    public int numObstacles;

    Collider floorCollider;
    // want to spawn obstacles in random areas in each tile
    private void spawn()
    {
        for (int i = 0; i < numObstacles; ++i)
        {
            float xLoc = Random.Range(center.x - tileSizeX / 2, center.x + tileSizeX / 2 );
            float zLoc = Random.Range(center.z - tileSizeZ / 2, center.z + tileSizeZ / 2);
            Instantiate(obstacle, new Vector3(xLoc, obstacle.transform.position.y, zLoc), Quaternion.identity);

        }
    }

	// Use this for initialization
	void Start () {
        floorCollider = GetComponentInChildren<Collider>();
        tileSizeX = floorCollider.bounds.size.x;
        tileSizeZ = floorCollider.bounds.size.z;
        center = floorCollider.bounds.center;
        spawn();
    }

    // Update is called once per frame
    // pick a random coordinate 
    // TODO: need to make sure obstacles are spread out
    void Update () {
     

    }
}
