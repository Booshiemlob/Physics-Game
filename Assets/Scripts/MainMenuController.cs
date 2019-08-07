using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void playGame()
    {
        //When the attached button is pressed the main game will load
        SceneManager.LoadScene("Game");
    }


    public void exitGame()
    {
        //When the attached button is pressed the game will exit
        Application.Quit();
    }
}