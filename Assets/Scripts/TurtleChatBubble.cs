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
    private void Awake(){
        backgroundSpriteRenderer = transform.Find("Chat").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }
    private void Start(){
        Setup("sdfgdsfgdsfgsdfgsdfgg");
        current = GetComponent<Transform>();
    }
    private void Setup(string text){
        textMeshPro.SetText(text);
    }
    
    void Update()
    {
        current.position = new Vector3(target.position.x,target.position.y,target.position.z);

    }

    void LateUpdate()
    {
        current.position = new Vector3(target.position.x,target.position.y,target.position.z);
    }
}
