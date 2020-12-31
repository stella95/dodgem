using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motionSphere : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            gameObject.transform.Translate(2, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)){
            gameObject.transform.Translate(-2, 0, 0);//gameObject = this, transform = metasxhmatismos, Translate = metatophsh(to transform p kaneis)
        }                                           //(x, y, z) x: de3ia-aristera, y: panw-katw, z: mpros-pisw, +: panw -: katw
        else if (Input.GetKeyDown(KeyCode.UpArrow)){
            gameObject.transform.Translate(0, 0, 2);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)){
            gameObject.transform.Translate(0, 0, -2);
        }
        else if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            gameObject.transform.Translate(0, 2, 0);
        }else if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            gameObject.transform.Translate(0, -2, 0);
        }
    }

}
