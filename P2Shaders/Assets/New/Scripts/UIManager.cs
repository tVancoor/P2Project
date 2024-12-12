using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;


public class UIManager : MonoBehaviour
{
	//Timer
	public int time = 0;
	public float decimalTime = 0;
	public TextMeshProUGUI timer;	
	public GameObject timesUP;
	public GameObject exit;
	public GameObject menu;
	
	public static UIManager instance;
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
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
       decimalTime += Time.deltaTime;
	   time = Mathf.RoundToInt(decimalTime);
	   timer.text = time.ToString();
	   
	   if (time == 30)
	   {
		   timesUP.SetActive(true);
		   exit.SetActive(true);
		   menu.SetActive(true); 
		   GameManager1.instance.timerObj.SetActive(false);
		}
    }
}
