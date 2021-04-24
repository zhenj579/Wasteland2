using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    private SpriteRenderer backgroundSpriteRenderer;
    private TextMeshPro textMeshPro; 
    private void Awake(){
        backgroundSpriteRenderer = transform.Find("Chat").GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }
    private void Start(){
        Setup("We must help sustain our enviorment! jump into the water and collect trash!");
    }
    private void Setup(string text){
        textMeshPro.SetText(text);
    }

}
