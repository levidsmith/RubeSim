﻿//2020 Levi D. Smith
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour {
    void Start() {
        
    }

    void Update() {
        
    }

    public void doStart() {
        SceneManager.LoadScene("game");

    }

    public void doQuit() {
        Application.Quit();
    }
}