using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] NavMeshAgent enemyAgent;
    [SerializeField] MeshRenderer enemyMr;
    public Transform playerTransform;
    public EnemyData enemyData;
    int health = 1;

    void Start()
    {
        //Scriptable Object substituindo valores base
        if (enemyData != null)
        {
            gameObject.name = enemyData.enemyName;
            enemyMr.material = enemyData.enemyMaterial;
            enemyAgent.speed = enemyData.speed;
            health = enemyData.health;
        }

        enemyData.Print();
    }

    void Update()
    {
        if (playerTransform != null)
        {
            enemyAgent.SetDestination(playerTransform.position);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.damageEvent.Invoke();
        }
    }
}
