using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaAnimales : MonoBehaviour
{
    public GameObject[] animales;
    
    void Start()
    {
        InvokeRepeating("SpawnAnimal",1,2);

    }



    void SpawnAnimal()
    {
        int ind = Random.Range(0, animales.Length);
        int z = Random.Range(-20,20);
        Vector3 posZ = new Vector3(animales[ind].transform.position.x, animales[ind].transform.position.y,z);
        Instantiate(animales[ind], posZ, animales[ind].transform.rotation);
    }
}
