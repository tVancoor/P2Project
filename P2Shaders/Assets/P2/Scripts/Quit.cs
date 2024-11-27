using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("P2Game");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
}
