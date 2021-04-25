using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    public AudioSource sfx;
    private Transform trans;
    private SpriteRenderer renderer;
    private float sum = 0f;
    // Start is called before the first frame update
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        renderer = GetComponent<SpriteRenderer>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        float sin = Mathf.Sin(sum) / 200;
        sum += 2*Time.deltaTime;
        trans.position = new Vector3(trans.position.x, trans.position.y + sin, trans.position.z);
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
