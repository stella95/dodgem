using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class colorCube : MonoBehaviour
{
    void Start()
    {
        Color color = new Color(Random.value, Random.value, Random.value, 0.27f);
        gameObject.GetComponent<Renderer>().material.color = color;
        
        if (gameObject.name != "SC")
        {
            transform.localScale = Vector3.one * Random.Range(1, 11);
        }
    }
}
