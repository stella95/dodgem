using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class createObject : MonoBehaviour
{
    //na ta emfanhseis esu xwris na uparxoun apo prin prepei na ta kaneis prefabs
    public GameObject sphere;// prefab gia sfaira
    public GameObject cube;// prefab gia kubo
    public GameObject cylinder;// prefab gia kulindro

    void Update(){// trexei ka8e frame
        
        //arxika elegxoume an pataei to spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int randomShape = Random.Range(1, 4);// to range pairnei times apo to prwto mexri prin to deutero orisma san if(i<3)
            if(randomShape == 1)
            {
                Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);// Insantiate dhmiourgei game objects otan trexei
                //1o orisma poio prefab (antikeimeno) 8es na emfanhseis
                //2o orisma einai pou 8es na to emfanhseis.. Vecotr3(x, y, z)suntetagmenes
                //3o orisma to quartenium einai to rotate.. otan dineis.identity shmainei gurw apo ton eauto t == 0 rotate.(xwris rotate)
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
