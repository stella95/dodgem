using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionCamera : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.Translate(2, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.Translate(-2, 0, 0);//gameObject = this, transform = metasxhmatismos, Translate = metatophsh(to transform p kaneis)
        }                                           //(x, y, z) x: de3ia-aristera, y: panw-katw, z: mpros-pisw, +: panw -: katw
        else if (Input.GetKeyDown(KeyCode.W))
        {
            gameObject.transform.Translate(0, 0, 2);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.Translate(0, 0, -2);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.transform.Translate(0, 2, 0);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            gameObject.transform.Translate(0, -2, 0);
        }
    }
}
