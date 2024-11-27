using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CoinCollec : MonoBehaviour
{
	
	void Start()
	{
	}
	
	public void OnCollisionEnter(Collision other)
    {
		Debug.Log("touching");
        if (other.gameObject.CompareTag("Player"))
        {
			Debug.Log("touching player");
            CoinShit.instance.coins2 += 1;
            Destroy(gameObject);
        }
    }
}
