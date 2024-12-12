using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsText;
    [SerializeField] MeshRenderer fakePlayerMr;
    [SerializeField] Material red, blue, yellow;
    
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
           //GameManager.instance.SaveGame();
            coinsText.text = "Total Coins Collected: " + GameManager.instance.coins;
        }
    }

    public void ChangeColor(int num)
    {
        switch (num)
        {
            case 1:
                fakePlayerMr.material = red;
                GameManager.instance.selectedSkin = red;
                break;
            case 2:
                fakePlayerMr.material = blue;
                GameManager.instance.selectedSkin = blue;
                break;
            case 3:
                fakePlayerMr.material = yellow;
                GameManager.instance.selectedSkin = yellow;
                break;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReturnToMenu();
        }
    }
}
