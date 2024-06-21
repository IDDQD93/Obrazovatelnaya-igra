using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;

    [SerializeField] private float jumpForce;
    [SerializeField] private float groundCheckRadius;
    [SerializeField] private Transform groundCheckPoint;
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private SpriteRenderer characterSprite;

    private Rigidbody2D rb;

    private bool isGrounded = false;
    private bool isFacingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, whatIsGround);


        float moveHorizpntal = Input.GetAxis("Horizontal");

        if (moveHorizpntal > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveHorizpntal < 0 && isFacingRight)
        {
            Flip();
        }


        Vector3 movement = new Vector3(moveHorizpntal, 0f, 0f);

        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, jumpForce));
        }
    }

    private void FixedUpdate()
    {
        float moveHorizpntal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizpntal, 0f, 0f);

        transform.Translate(movement * playerSpeed * Time.deltaTime);
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

    }

}



