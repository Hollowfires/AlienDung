﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameStart()
    {
        SceneManager.LoadScene(0);
    }

    public void creditsScene()
    {
        //SceneManager.LoadScene();
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
