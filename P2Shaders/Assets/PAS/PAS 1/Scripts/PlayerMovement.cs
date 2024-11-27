using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody playerRb;
    [SerializeField] MeshRenderer playerMr;
    int health = 5;
    int speed = 5;

    private void Start()
    {
    //    playerMr.material = GameManager.instance.selectedSkin;

    //   GameManager.instance.damageEvent.RemoveListener(TakeDamage);
    //    GameManager.instance.damageEvent.AddListener(TakeDamage);
    }


    void Update()
    {
        playerRb.linearVelocity = 
            new Vector3 (Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * speed;
    }

    public void TakeDamage()
    {
        Debug.Log("Player took 1 damage");
        health --;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
