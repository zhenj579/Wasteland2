using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementDoc : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform trans;

    private float horizontal;
    private float vertical;

    public float runSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical).normalized * runSpeed * Time.deltaTime;
    }
}