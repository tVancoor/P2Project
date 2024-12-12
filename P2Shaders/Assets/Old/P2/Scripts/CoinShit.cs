using UnityEngine.Events;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class CoinShit : MonoBehaviour
{
	public int max = 3;
	public int coins2;
	public GameObject endScreen;	
	[SerializeField] TextMeshProUGUI orbcount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        orbcount.text = coins2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        orbcount.text = coins2.ToString();
		
		if (coins2 == max)
		{
			endScreen.SetActive(true);
		}
    }
	
	public static CoinShit instance;
	private void Awake()
    {
       if (instance != null && instance != this)
        {
            Destroy(gameObject);
		}
        else
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }

        //Carregar jogo na inicialização apenas
      //LoadGame();
    }
	
	//public void SaveGame()
    //{
    //    PlayerPrefs.SetInt("Coins2", coins2);
    //}
    //public void LoadGame()
    //{
    //    coins2 = PlayerPrefs.GetInt("Coins2");
    //}
    
}
