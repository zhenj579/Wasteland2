using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTracker : MonoBehaviour
{

    public Transform player;
    public float socialDistance;
    public float speed;
    private Transform trans;
    private Rigidbody2D rb;
    private Vector2 toPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        toPlayer = (Vector2)player.position - rb.position;
        if (toPlayer != Vector2.zero)
        {
            float angle = Mathf.Atan2(toPlayer.y, toPlayer.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }
    private void FixedUpdate()
    {
        if (toPlayer.magnitude > socialDistance)
            rb.velocity = toPlayer.normalized * speed * Time.deltaTime;
        else
            rb.velocity = Vector2.zero;
    }

}
