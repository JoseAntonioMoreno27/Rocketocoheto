using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoScripts : MonoBehaviour
{

    public float velocidad;                         // Velocity of the obstacles (pipes)



    
    void Start()
    {
        
    }

    
    void Update()
    {

        transform.position += Vector3.left * velocidad * Time.deltaTime;


    }
}
