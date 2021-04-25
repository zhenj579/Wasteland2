using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
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
        Setup("We must help sustain our environment! Jump into the water and collect trash!");
        current = GetComponent<Transform>();
    }
    private void Setup(string text){
        textMeshPro.SetText(text);
    }
    
    void Update()
    {
        current.position = new Vector3(target.position.x + 15, target.position.y + 5, target.position.z);     
    }
}
