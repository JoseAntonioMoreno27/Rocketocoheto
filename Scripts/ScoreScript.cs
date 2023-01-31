using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;            // So I am able to use the TM funcionalities 

public class ScoreScript : MonoBehaviour
{

    public static int Score = 0;

    void Start()
    {
        Score = 0; 


    }

    
    void Update()
    {

        GetComponent<TextMeshProUGUI>().text = Score.ToString();

    }
}
