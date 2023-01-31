using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



// This is the Scene Management Script for my project


public class ControladorEscenaScr : MonoBehaviour
{

    public GameObject GameOverScene;



    void Start()
    {
        Time.timeScale = 1;
    }

    
    void Update()
    {
        
    }

    public void Gameover()
    {
        GameOverScene.SetActive(true);
        Time.timeScale = 0;

    }

    public void Restart()
    {

        SceneManager.LoadScene(0);



    }
}
