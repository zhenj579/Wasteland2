using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform trans;
    private SpriteRenderer sr;
    public Camera cam;

    private float horizontal;
    private float vertical;

    public float runSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

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

        //Vector2 mousePos = Input.mousePosition;
        //mousePos = cam.ScreenToWorldPoint(mousePos);
        //mousePos -= (Vector2)trans.position;

        //if (mousePos != Vector2.zero)
        //{
        //    float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        //    transform.rotation = Quaternion.AngleAxis(angle, (mousePos.x < 0 ? Vector3.back : Vector3.forward));
        //}
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical).normalized * runSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Trash"))
        {
            Destroy(other.gameObject);
        }
    }
}
