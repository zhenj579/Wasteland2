using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    private bool clear;
    // Start is called before the first frame update
    void Start()
    {
        clear = false;
    }

    public bool isClear()
    {
        return clear;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] trashList = GameObject.FindGameObjectsWithTag("Trash");
        if(trashList.Length == 0)
        {
            clear = true;
        }
    }
}
