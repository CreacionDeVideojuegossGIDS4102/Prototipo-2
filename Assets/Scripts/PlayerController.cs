using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Autor Fernando Arvizu Sotelo
// Descripcion: Mueve el Player
// Fecha: 26/09/2024

public class PlayerController : MonoBehaviour
{
    public GameObject proyectil;
    void Start()
    {
        
    }

    void Update()
    {
        float coordX = Input.GetAxis("Horizontal");

        if (transform.position.z>23)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 23);
        }

        if (transform.position.z<-4)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -4);
        }

        transform.Translate(Vector3.right *Time.deltaTime*30*coordX);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(proyectil, gameObject.transform.position, transform.rotation);
        }
        
        
    }
}
