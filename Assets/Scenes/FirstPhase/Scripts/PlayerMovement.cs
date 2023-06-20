using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }

        if ( moveX > 0 )
        {
            sr.flipX = false;
        } 
        else if (moveX < 0) 
        {
            sr.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(transform.position, 1.5f, LayerMask.GetMask("Ground"));

        if (isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }
    }
}
