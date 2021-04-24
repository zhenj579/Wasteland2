using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    private SpriteRenderer map;
    private Vector2 dimensions;

    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        GameObject[] gameobjs = scene.GetRootGameObjects();
        GameObject bg = gameobjs[1];
        map = bg.GetComponent<SpriteRenderer>();
        dimensions = map.size;
        Debug.Log(dimensions);
        string[] trashPaths = {"Assets/Trash/plasticbag.png", "Assets/Trash/plasticbottle.png", "Assets/Trash/sodacan.png"};
        for(int i = 0; i < 10; i++)
        {
            GameObject trash = new GameObject();
            float x  = Random.Range((-1*dimensions.x)+1, dimensions.x);
            float y = Random.Range((-1*dimensions.y)+1, dimensions.y);
            trash.transform.position = new Vector2(x,y);
            SpriteRenderer trashRenderer = trash.AddComponent<SpriteRenderer>();
            int trashIndex = Random.Range(0,3);
            Texture2D tex = CreateTexture(trashPaths[trashIndex]);
            Sprite spr = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(x/2, y/2), 100.0f);
            trashRenderer.sprite = spr;
        }
    }

    Texture2D CreateTexture(string path)
    {
        Texture2D tex = new Texture2D(2,2);
        byte[] fileData = File.ReadAllBytes(path);
        tex.LoadImage(fileData);
        return tex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
