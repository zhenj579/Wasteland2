using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform trans;
    private SpriteRenderer sr;
    public Camera cam;

    private GameObject chatBubble;
    private float horizontal;
    private float vertical;
    private bool end;

    public float runSpeed;

    void Start()
    {
        chatBubble = GameObject.Find("ChatBubble");
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
        end = false;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if(!end && GameObject.FindGameObjectsWithTag("Trash").Length == 0)
        {
            end = true;
            chatBubble.SetActive(true);
        }
        if(horizontal < 0)
        {
            sr.flipX = false;
            transform.rotation = Quaternion.AngleAxis(35, Vector3.forward);
        } else if(horizontal > 0)
        {
            sr.flipX = true;
            transform.rotation = Quaternion.AngleAxis(-35, Vector3.forward);
        } else
        {
            transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical).normalized * runSpeed * Time.deltaTime;
    }

}
