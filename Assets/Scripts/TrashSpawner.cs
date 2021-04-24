using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject trash;
    public Sprite plasticBag;
    public Sprite can;
    public Sprite plasticBottle;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = trash.GetComponent<SpriteRenderer>();
        BoxCollider2D bc = trash.GetComponent<BoxCollider2D>();
        bc.size = new Vector2(1, 1);
        for (int i = 0; i < 32; i++)
        {
            int random = Random.Range(0, 3);
            if (random == 0)
            {
                sr.sprite = plasticBag;
            }
            if (random == 1)
            {
                sr.sprite = can;
            }
            if (random == 2)
            {
                sr.sprite = plasticBottle;
            }
            Instantiate(trash, new Vector3(Random.Range(-16, 16), Random.Range(-8, 8), -1), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
