﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ExitGame(){
    Application.Quit();
    }
    public void LoadScene(string Scene){
        SceneManager.LoadScene(Scene,LoadSceneMode.Single);
    }
}
