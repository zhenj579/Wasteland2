using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
    public GameObject plastic_bottle;
    public GameObject plastic_bag;
    public GameObject can;
    public Sprite plasticBagSprite;
    public Sprite canSprite;
    public Sprite plasticBottleSprite;
    private SpriteRenderer bottleRenderer;
    private BoxCollider2D bottleCollider;
    private SpriteRenderer bagRenderer;
    private BoxCollider2D bagCollider;
    private SpriteRenderer canRenderer;
    private BoxCollider2D canCollider;        
    // Start is called before the first frame update
    public void Start()
    {
        GameObject thisObj = GameObject.Find("ChatBubble");
        thisObj.SetActive(false);
        plastic_bag.name = "plastic_bag";
        can.name = "can";
        plastic_bottle.name = "plastic_bottle";
        bottleRenderer = plastic_bottle.GetComponent<SpriteRenderer>();
        bagRenderer = plastic_bag.GetComponent<SpriteRenderer>();
        canRenderer = can.GetComponent<SpriteRenderer>();
        bottleRenderer.sprite = plasticBottleSprite;
        bagRenderer.sprite = plasticBagSprite;
        canRenderer.sprite = canSprite;
        Vector2 colliderSize = new Vector2(1,1);
        bottleCollider = plastic_bottle.GetComponent<BoxCollider2D>();
        bottleCollider.size = colliderSize;
        canCollider = can.GetComponent<BoxCollider2D>();
        canCollider.size = colliderSize;
        bagCollider = plastic_bag.GetComponent<BoxCollider2D>();
        bagCollider.size = colliderSize;        
        for (int i = 0; i < 32; i++)
        {
            int randNum = Random.Range(0,3);
            if(randNum == 0)
            {
                Instantiate(plastic_bottle, new Vector3(Random.Range(-15, 16), Random.Range(-7, 8), -1), Quaternion.identity);
            }
            else if(randNum == 1)
            {
                Instantiate(can, new Vector3(Random.Range(-15, 16), Random.Range(-7, 8), -1), Quaternion.identity);
            }
            else
            {
                Instantiate(plastic_bag, new Vector3(Random.Range(-15, 16), Random.Range(-7, 8), -1), Quaternion.identity);
            }
        }
        Destroy(this);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
