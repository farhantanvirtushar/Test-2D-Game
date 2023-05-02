using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    private float velocityX = 7f;
    private float maxVelocityY = 7f;

    // Start is called before the first frame update
    void Start()
    {
        // rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        float dirX = Input.GetAxis("Horizontal");


        if(Input.GetKey("space")) {
            
            if(Mathf.Abs(rigidbody2D.velocity.y)  < 0.01) {
                rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, 7f, 0);
            }
            
        }

        rigidbody2D.velocity = new Vector3(dirX * velocityX, rigidbody2D.velocity.y, 0);
    }
    
}
