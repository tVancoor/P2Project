using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SkinManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI coinsText;
	[SerializeField] TextMeshProUGUI orbText;
	[SerializeField] TextMeshProUGUI crystalText;
    [SerializeField] MeshRenderer fakePlayerMr;
    [SerializeField] Material skin1, skin2, skin3, skin4, skin5;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("P3Menu"))
        {
           //GameManager.instance.SaveGame();
           coinsText.text = "Gold Coins: " + GameManager1.instance.goldC;
		   orbText.text = "Fire Orbs: " + GameManager1.instance.fireO;
           crystalText.text = "Ice Crystals: " + GameManager1.instance.iceC;

        }
    }
    
	public void ChangeSkin(int num)
    {
        switch (num)
        {
            case 1:
                fakePlayerMr.material = skin1;
                GameManager1.instance.playerMat = skin1;
                break;
            case 2:
                fakePlayerMr.material = skin2;
                GameManager1.instance.playerMat = skin2;
                break;
            case 3:
                fakePlayerMr.material = skin3;
                GameManager1.instance.playerMat = skin3;
                break;
			case 4:
                fakePlayerMr.material = skin4;
                GameManager1.instance.playerMat = skin4;
                break;
			case 5:
                fakePlayerMr.material = skin5;
                GameManager1.instance.playerMat = skin5;
                break;				
        }
    }
	
    public void StartGame()
    {
        SceneManager.LoadScene("P3");
    }

    public void ReturnToMenu()
    {
        //SceneManager.LoadScene("P3Menu");
    }
}
