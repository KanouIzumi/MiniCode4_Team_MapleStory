﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonRestart_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Level 0");
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void Instruction()
    {
        SceneManager.LoadScene("InstructionScene");
    }
    public void Credit()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
