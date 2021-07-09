using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator PlayerAnimator;
    public float speed = 1f;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
  
        Vector2 movement = new Vector2(moveHorizontal,0);

        movement.Normalize();

        rb2d.velocity = movement * speed;



        if (moveHorizontal <= -0.1f)
        {
            PlayerAnimator.SetBool("a", true);
        }
        else if (moveHorizontal == 0)
        {
            PlayerAnimator.SetBool("a", false);
        }

        if (moveHorizontal >= 0.1f)
        {
            PlayerAnimator.SetBool("d", true);
        }

        else if (moveHorizontal <= 0)
        {
            PlayerAnimator.SetBool("d", false);
        }

    }
}