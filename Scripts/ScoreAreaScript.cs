using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaScript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.Score++;      // adds +1 to the score every time it passes through an area zone 
    }
}
