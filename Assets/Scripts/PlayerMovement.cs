using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform trans;
    private SpriteRenderer sr;
    public Camera cam;

    private float horizontal;
    private float vertical;
    private bool end;
    private bool walk;
    public float runSpeed;

    void Start()
    {
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
            Scene scene = SceneManager.GetActiveScene();
            var game_objects = new List<GameObject>();
            scene.GetRootGameObjects(game_objects);
            int chatBubbleIndex = 2;
            if(Application.isEditor) chatBubbleIndex++;
            GameObject chatBubble = game_objects[chatBubbleIndex];
            chatBubble.SetActive(true);
        }
        if(horizontal < 0)
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up) * Quaternion.AngleAxis(-35, Vector3.forward);
            walk = true;
        } else if(horizontal > 0)
        {
            transform.rotation = Quaternion.AngleAxis(0, Vector3.up) * Quaternion.AngleAxis(-35, Vector3.forward);
            walk = true;
        } else
        {
            if (walk)
            {
                transform.rotation *= Quaternion.AngleAxis(35, Vector3.forward);
                walk = false;
            }
        }

    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal, vertical).normalized * runSpeed * Time.deltaTime;
    }

}
