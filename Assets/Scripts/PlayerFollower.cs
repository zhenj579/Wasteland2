using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{

    private Transform cam;
    public bool clamp;
    public bool follow;
    public Transform target;
    public Vector2 min;
    public Vector2 max;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            cam.position = new Vector3(target.position.x, target.position.y, cam.position.z);
        }
        if (clamp)
        {
            cam.position = new Vector3(Mathf.Clamp(cam.position.x, min.x, max.x), Mathf.Clamp(cam.position.y, min.y, max.y), cam.position.z);
        }
    }
}
