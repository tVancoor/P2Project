using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic;

public class MenuUIManager : MonoBehaviour
{
	public TextMeshProUGUI coinText;
	public TextMeshProUGUI iceText;
	public TextMeshProUGUI fireText;	
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinText.text = ("Gold Coins collected: " + GameManager1.instance.goldC.ToString());
		fireText.text = ("Fire Orbs collected: " + GameManager1.instance.fireO.ToString());
        iceText.text = ("Ice Crystals collected: " + GameManager1.instance.iceC.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
