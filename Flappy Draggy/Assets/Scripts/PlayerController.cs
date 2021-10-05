using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    [SerializeField] private float UpSpeed;

    // components
    private Animator anim;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		// check for user input
        if (Input.GetButtonDown ("Fire1")) 
		{
            // trigger animation
			anim.SetTrigger ("Fly");

            // move up
            Vector2 dir;
            dir = Vector2.zero;
            dir.y = 1;

            rb.velocity += dir * UpSpeed;
		}
    }

    void FixedUpdate()
    {
        
    }
}
