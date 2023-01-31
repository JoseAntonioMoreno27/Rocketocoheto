using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsGenScript : MonoBehaviour
{
    public float timeMax = 1;
    private float timeinitial = 0;
    public GameObject obstaculo;
    public float height;


    void Start()
    {

        GameObject obstaculoNuevo = Instantiate(obstaculo);                                     // Instantiate to create the obstacles in game 
        obstaculoNuevo.transform.position = transform.position + new Vector3(0, 0, 0);          // I didnt add the float "height" on void "Start" in order to make the first obstacle always at the same height
        Destroy(obstaculoNuevo, 10);    // to optimize the game I decided to destroy the created obstacles after 10 seconds
    }

    
    void Update()
    {
        if (timeinitial > timeMax)
        {
            GameObject obstaculoNuevo = Instantiate(obstaculo);
            obstaculoNuevo.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);                   // In here I do add the height 
            Destroy(obstaculoNuevo, 10);
            timeinitial = 0;
       
        }

        else
        {
            timeinitial += Time.deltaTime;

        }
    }
}
