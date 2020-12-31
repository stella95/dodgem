using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    float x;
    float y;
    float z;

    void Start()
    {
        x = Random.Range(0.1f, 0.9f);
        y = Random.Range(0.1f, 0.9f);
        z = Random.Range(0.1f, 0.9f);
    }

    void Update()
    {
        transform.Translate(x, y, z);
    }
}
