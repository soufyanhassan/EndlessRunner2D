﻿using UnityEngine;
using System.Collections;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuPanel; //de panel waar de pauze menu is gemaakt
    private bool isPaused = false; //een boolean isPaused is "false"


    void Start ()
    {
        Time.timeScale = 1; //de game is NIET op pauze gezet
	}
	
	void Update ()
    {
	    if(Input.GetKeyUp(KeyCode.Escape) && !isPaused)
        {
            PauseGame(); //de functie PauseGame() wordt aangeroepen
        }
        else if (Input.GetKey(KeyCode.Escape) && !isPaused)
        {
            UnpauseGame(); //de functie UnpauseGame() wordt aangeroepen
        }
	}

    public void PauseGame()
    {
        Time.timeScale = 0; //de game is op pauze gezet
        isPaused = true; //de boolean isPaused is op "true" gezet, wanneer de game pauzeert
    }

    public void UnpauseGame()
    {
        Time.timeScale = 1; //de game gaat weer verder
        isPaused = false; //de boolean isPaused is op "false" gezet, wanneer de game NIET pauzeert
    }
}
