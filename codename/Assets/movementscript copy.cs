using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscript : MonoBehaviour
{
    Rigidbody2D body;

    public float horizontal;
    public float vertical;
    public Vector2 velocity;

    public float runSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        body.velocity = velocity;
    }
}
