using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{	
	[SerializeField] public GameObject timerObj;
	
	//Co Routine
	private IEnumerator coroutine;
	public TextMeshProUGUI startText;
	public GameObject startObj;
	
	//Collectables
	public Material playerMat;
	public int goldC;
	public int fireO;
	public int iceC;
	
	//public delegate void OnSaveGame();
	//public static event OnSaveGame onSaveGame;
	
	//public delegate void OnLoadGame();
	//public static event OnLoadGame onLoadGame;
	
	//Singleton
    public static GameManager1 instance;
	
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
		Debug.Log("WHY");
		
		coroutine = GameStartCR(2);
		StartCoroutine(coroutine);		
		
		LoadPrefs();
		//onSaveGame += SavePrefs;
		//nLoadGame += LoadPrefs;
				
		//onLoadGame?.Invoke();
		//GameManager1.onLoadGame = null;			
	}	
		
		private IEnumerator GameStartCR(float waitTime)
	{
		yield return new WaitForSeconds(waitTime);
		Debug.Log("Working");
		startText.text = "START";
		//anim.SetTrigger("StartATriiger");
		
		yield return new WaitForSeconds(waitTime);
		Debug.Log("TEST");
		startObj.SetActive(false);
		timerObj.SetActive(true);
		UIManager.instance.decimalTime = 0;
	}
	
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			Debug.Log("Salvando");
			SavePrefs();
		}
		
	}

	
	//Save Delegate Scriptable Object Test
	//public void SaveDelegate()
	//{
		//nSaveGame?.Invoke();
		//GameManager1.onSaveGame = null;
	//}
	
	//Save|Load Functions
    public void SavePrefs()
    {
        PlayerPrefs.instance.savedData.goldCoins = goldC;
		PlayerPrefs.instance.savedData.fireOrbs = fireO;
		PlayerPrefs.instance.savedData.iceCrystals = iceC;
		PlayerPrefs.instance.savedData.playerCM = playerMat;
    }
    public void LoadPrefs()
    {
       goldC = PlayerPrefs.instance.savedData.goldCoins;
	   fireO = PlayerPrefs.instance.savedData.fireOrbs;
	   iceC = PlayerPrefs.instance.savedData.iceCrystals;
	   playerMat = PlayerPrefs.instance.savedData.playerCM;
    }
	
	
	
	void OnEnable(){ Debug.Log("Enabled"); SceneManager.sceneLoaded += StartCoroutineOnSceneLoad;}
	void OnDisable(){ SceneManager.sceneLoaded -= StartCoroutineOnSceneLoad;}
	
	private void StartCoroutineOnSceneLoad(Scene scene, LoadSceneMode mode)
	{
		Debug.Log("Level Loaded");
		Debug.Log(scene.name);
		Debug.Log(mode);		
		
			
			
		
	}	
		
	public void StartGame()
	{
		SceneManager.LoadScene("P3");
	}
	public void GameMenu()
    {
        SceneManager.LoadScene("P3Menu");
    }

    public void Quitgame()
    {
        Application.Quit();
    }
	
}
