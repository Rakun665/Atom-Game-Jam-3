using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private Rigidbody2D rb;
    public float jumpForce;
    Animator PlayerAnimator;
    private Rigidbody2D rb2d;

    private bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(Vector2.right *Time.deltaTime * speed * horizontalInput);
        horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);


        if  (horizontalInput <= -0.1f)
        {
            PlayerAnimator.SetBool("a", true);
        }
        else if (horizontalInput == 0)
        {
            PlayerAnimator.SetBool("a", false);
        }

        if (horizontalInput >= 0.1f)
        {
            PlayerAnimator.SetBool("d", true);
        }

        else if (horizontalInput <= 0)
        {
            PlayerAnimator.SetBool("d", false);
        }
    }
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
                rb.velocity = Vector2.up * jumpForce;
            jumpTimeCounter -= Time.deltaTime;
        }
        else
        {
            isJumping = false;
        }
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                isJumping = false;
            }
        }



    }


}
