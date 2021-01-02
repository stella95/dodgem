using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class createObject : MonoBehaviour
{
    public GameObject sphere;
    public GameObject cube;
    public GameObject cylinder;

    void Update(){
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomShape = Random.Range(1, 4);
            if(randomShape == 1)
            {
                Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else if (randomShape == 2)
            {
                Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(cylinder, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
}
