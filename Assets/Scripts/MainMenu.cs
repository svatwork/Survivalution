using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Awake()
    {
        RoundManager.RoundCount = 0;
        PlayerStats.maxHealth = 100;
        PlayerStats.healthRegenRate = 0f;
        PlayerStats.movementSpeed = 5f;
    }

    public void PlayGame()
    {
        UnityEngine.Debug.Log("PlayGame");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void QuitGame()
    {
        UnityEngine.Debug.Log("QUIT!");
        Application.Quit();
    }

}