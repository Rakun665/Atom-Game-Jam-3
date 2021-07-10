using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private Rigidbody2D rb;
    Animator PlayerAnimator;
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


        if (horizontalInput <= -0.1f)
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

}