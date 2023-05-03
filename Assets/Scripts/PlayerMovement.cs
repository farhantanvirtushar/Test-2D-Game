using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;

    public Animator animator;

    private SpriteRenderer spriteRenderer;

    private float velocityX = 7f;
    private float maxVelocityY = 7f;
    private float dirX = 0f;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        dirX = Input.GetAxis("Horizontal");

        UpdatePlayerVelocity();

        UpdatePlayerAnimatioin();
    }

    void UpdatePlayerVelocity()
    {

        if (Input.GetKey("space"))
        {

            if (Mathf.Abs(rigidbody2D.velocity.y) < 0.01)
            {
                rigidbody2D.velocity = new Vector3(rigidbody2D.velocity.x, maxVelocityY, 0);
            }

        }


        rigidbody2D.velocity = new Vector3(dirX * velocityX, rigidbody2D.velocity.y, 0);
    }
    void UpdatePlayerAnimatioin()
    {
        if (dirX > 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = false;

        }
        else if (dirX < 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = true;

        }
        else
        {
            animator.SetBool("running", false);

        }
    }

}
