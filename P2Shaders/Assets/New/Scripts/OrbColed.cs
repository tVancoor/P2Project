using UnityEngine;

public class OrbColed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void OnCollisionEnter(Collision other)
    {
		Debug.Log("touching");
        if (other.gameObject.CompareTag("Player"))
        {
			Debug.Log("touching player");
            GameManager1.instance.fireO += 1;
            Destroy(gameObject);
        }
    }
}
