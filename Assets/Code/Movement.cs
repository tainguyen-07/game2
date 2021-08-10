using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
     private Rigidbody2D rb;
     private SpriteRenderer sprite;
     private Animator animator;
     private float dirX = 0f;
     [SerializeField] private float moveSpeed = 7f;
     [SerializeField] private float jumpForce = 5f;
    private void Start()
    {
        rb =  GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        if (dirX > 0f)
        {
            animator.SetBool("Speed", true);
            sprite.flipX = false;
        }
        else if (dirX < 0f)
        {
            animator.SetBool("Speed", true);
            sprite.flipX = true;
        }
        else 
        {
            animator.SetBool("Speed", false);
        }

    }
}

