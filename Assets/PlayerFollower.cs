using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour
{

    private Transform cam;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        // Debug.Log(player.position);
=======
>>>>>>> d5a0d14743c8e5848469543be2439e10043a1c1f
        cam.position = new Vector3(player.position.x, player.position.y, cam.position.z);
    }
}
