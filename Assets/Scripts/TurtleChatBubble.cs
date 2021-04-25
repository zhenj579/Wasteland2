using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TurtleChatBubble : MonoBehaviour
{
    private SpriteRenderer backgroundSpriteRenderer;
    public Transform target;
    private Transform current;
    private TextMeshPro textMeshPro;
    private bool started = true; 
    private void Awake(){
        backgroundSpriteRenderer = transform.Find("Chat").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }
    private void Start(){
        GameObject thisObj = GameObject.Find("ChatBubble");
        if(started)
        {
            thisObj.SetActive(false);
            started = false;
        }
        else
        {
            thisObj.SetActive(true);
        }
        Setup("Thanks for cleaning up the ocean! Head up to the surface if you want to help collect more trash!");
        current = GetComponent<Transform>();
    }
    private void Setup(string text){
        textMeshPro.SetText(text);
    }
    
    void Update()
    {
        current.position = new Vector3(target.position.x + 55, target.position.y - 8, target.position.z);
    }

}
