using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public AudioSource sfx;
    private SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            sfx.Play();
            Destroy(renderer);
            Destroy(this);
            Destroy(this.gameObject,1);
        }
    }
}
