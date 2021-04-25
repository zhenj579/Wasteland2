using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCharScript : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D body;
    public AudioSource audioSource;
    
        // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f,0.0f);
        transform.position = transform.position + 4*horizontal * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space)){
            body.AddForce(new Vector2(0,500));
        }
        if(Input.GetKeyDown(KeyCode.S)){
            body.AddForce(new Vector2(0,-1000));
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            audioSource.time = 1.60f;
            audioSource.Play();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (other.CompareTag("Trash") && Input.GetKey(KeyCode.E))
            {
                //audioSource.time = 1.60f;
                //audioSource.Play();
                other.GetComponent<Rigidbody2D>().AddForce(new Vector2(Input.GetAxis("Horizontal") * 100, 0));
            }
        }
    }
}
