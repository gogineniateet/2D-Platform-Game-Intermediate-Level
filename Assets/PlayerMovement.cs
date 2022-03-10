using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody2D rb;
    SpriteRenderer render;
    Animator animator;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
       float inputX =  Input.GetAxis("Horizontal") * playerSpeed;
        rb.velocity = new Vector3(inputX, rb.velocity.y);
        if (inputX < 0)
        {
            render.flipX = true;
        }
        else
            render.flipX = false;

        animator.SetBool("isWalk", inputX != 0);
    }

    
}
