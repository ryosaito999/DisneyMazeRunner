using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
    Rigidbody rb;

    public float jumpForce;
    public float horizontalSpeed;
    

    void playerJump()
    {

      
        Debug.Log("Should Jump");

        //make sure ray starts at center of collider and reaches underneath the player 
        Vector3 rayOrigin = GetComponent<Collider>().bounds.center;
        float rayDistance = GetComponent<Collider>().bounds.extents.y + 0.1f;

        //declare a ray and shoot it downwards 
        Ray ray = new Ray();
        ray.origin = rayOrigin;
        ray.direction = Vector3.down;

        if (Physics.Raycast(ray, rayDistance, 1))
        {
            Debug.Log("Jumping");
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }



// Use this for initialization
void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
      

    }

    void FixedUpdate()
    {
        // left-right movement code
        float horizontalInput = Input.GetAxisRaw("Horizontal") * horizontalSpeed;
        transform.Translate(horizontalInput, 0, 0);

        //jumping code
        if(Input.GetAxisRaw("Jump") == 1)
        {
            playerJump();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("hit Obstacle!");
            gameManager.gameOver = true;
        }
    }
}
