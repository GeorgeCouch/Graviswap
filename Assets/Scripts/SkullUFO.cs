using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullUFO : MonoBehaviour
{
    private float speed = .5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;
    }
}

