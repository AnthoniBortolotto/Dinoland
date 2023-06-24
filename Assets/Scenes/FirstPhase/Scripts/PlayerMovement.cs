using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator PlayerAnim;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    private void Start()
    {
        PlayerAnim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            PlayerAnim.SetBool("DINO_Jump", true);
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = false;
        }

        if ( moveX > 0 )
        {
            PlayerAnim.SetBool("DINO_Walk", true);
            sr.flipX = false;
        } 
        else if (moveX < 0) 
        {
            PlayerAnim.SetBool("DINO_Walk", true); 
            sr.flipX = true;
        }
        else
        {
            PlayerAnim.SetBool("DINO_Walk", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if ( collision.gameObject.name == "Ground")
        {
            PlayerAnim.SetBool("DINO_Jump", false);
            isJumping = false;
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
