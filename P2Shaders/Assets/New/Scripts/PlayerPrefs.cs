using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.IO;

public class PlayerPrefs : MonoBehaviour
{		
	public static PlayerPrefs instance;
	public SavedData savedData = new SavedData();	
	
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
	}
	
	//private void OnEnable()
	//{
		//GameManager1.onSaveGame += SaveToJson;
		//GameManager1.onLoadGame += LoadFromJson;
	//}
	
	public void SaveToJson()
	{
		
		string playerData = JsonUtility.ToJson(savedData);
		string filePath = Application.persistentDataPath + "/PlayerData.json";
		Debug.Log(filePath);
		System.IO.File.WriteAllText(filePath, playerData);
		Debug.Log("Game Saved!");
	}	
	
	public void LoadFromJson()
	{
		
		string filePath = Application.persistentDataPath + "/PlayerData.json";
		string playerData = System.IO.File.ReadAllText(filePath);		
		savedData = JsonUtility.FromJson<SavedData>(playerData);
		Debug.Log("Game Loaded!");
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.S))
		{
			SaveToJson();
		}
	}
}

	[System.Serializable]
	public class SavedData
	{
		public int goldCoins;
		public int fireOrbs;
		public int iceCrystals;
		public Material playerCM;		
		
	}
