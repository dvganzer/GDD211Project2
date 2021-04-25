using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public static float speed = 10f;
    public Rigidbody2D rb;
    Vector2 move;
    public Animator animator;
   public GameObject player;
   
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Horizontal", move.x);
       
        animator.SetFloat("Speed", move.sqrMagnitude);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Shoot", true);
            speed = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("Shoot", false);
            speed = 5f;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float jumpVelocity = 100f;
            rb.velocity = Vector2.up * jumpVelocity;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
   
    }


}
