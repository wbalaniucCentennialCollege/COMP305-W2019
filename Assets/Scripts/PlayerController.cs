using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // PUBLIC VARIABLES
    public float speed = 10.0f;
    public float jumpForce = 500.0f;

    // PRIVATE VARIABLES
    private Rigidbody2D rBody;
    private bool canJump = false;

    // Reserved function. Runs only once when the object is created.
    // Used for initialization
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // Listens to my space bar key being pressed
        {
            rBody.AddForce(new Vector2(0, jumpForce));
            canJump = false;
        }
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// Use FixedUpdate for Physics-based movement only
    /// </summary>
    void FixedUpdate()
    {
        float horiz = Input.GetAxis("Horizontal");

        rBody.velocity = new Vector2(horiz * speed, rBody.velocity.y);
    }
}
