using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour {

    private bool facingRight = true;
    private float moveDirection;
    private Rigidbody2D rb;

    public float walkSpeed;
    public float runSpeed;
    

    void Start()
    {
        //moveDirection = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveDirection = Input.GetAxis("Horizontal");

        if (moveDirection > 0 && !facingRight)
        {
            Flip();
        }
        else if(moveDirection < 0 && facingRight)
        {
            Flip();
        }
        

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection * walkSpeed, rb.velocity.y);
    }

    void Flip()
    {
        facingRight = !facingRight;
        if (!facingRight)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        
    }
}
