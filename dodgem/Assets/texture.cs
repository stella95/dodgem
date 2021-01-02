using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class texture : MonoBehaviour
{
    private float flag = 0;
    public Texture textures;
    public Material mat;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (flag == 0)
            {
                GetComponent<Renderer>().material = null;
                GetComponent<Renderer>().material.mainTexture = textures;
                flag = 1;

            }else if (flag == 1)
            {
                GetComponent<Renderer>().material = mat;
                GetComponent<Renderer>().material.mainTexture = null;
                flag = 0;
            }
        }
    }
}
