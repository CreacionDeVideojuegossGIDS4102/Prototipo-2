using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 //Fernando Arvizu Sotelo

public class Move : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        if(transform.position.x >30){
            Destroy(gameObject);
        }else if(transform.position.x<-14){
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward*20*Time.deltaTime);
    }
}
