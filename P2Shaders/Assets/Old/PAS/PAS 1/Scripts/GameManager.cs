using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    //Informa��o armazenada
    public UnityEvent damageEvent;

    public Material selectedSkin;
    public int coins;

    //Estrutura Singleton
    public static GameManager instance;
    private void Awake()
    {
       if (instance != null && instance != this)
        {
            Destroy(gameObject);
		}
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        //Carregar jogo na inicializa��o apenas
      //LoadGame();
    }

    //public void SaveGame()
    //{
    //    PlayerPrefs.SetInt("Coins", coins);
    //}
    //public void LoadGame()
    //{
    //   coins = PlayerPrefs.GetInt("Coins");
    //}
    

        
}
