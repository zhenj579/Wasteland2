using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayInside : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -15f, 15.5f), Mathf.Clamp(transform.position.y, -7f, 7f), transform.position.z);
    }
}
