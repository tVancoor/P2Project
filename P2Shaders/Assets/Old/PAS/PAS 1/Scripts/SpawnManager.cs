using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] EnemyData[] enemyTypes;

    [SerializeField] GameObject coinPrefab;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] Transform playerTransform;
    int enemyCount; 
    int count;

    private void Start()
    {
        StartCoroutine("CoinSpawnCoroutine");
        StartCoroutine("EnemySpawnCoroutine", 5);
    }
    IEnumerator CoinSpawnCoroutine()
    {        
        while (count < 10)
        {
            count++;
            Vector3 randomPos = new Vector3(Random.Range(-5, 5), 0.5f, Random.Range(-5, 5));
            Instantiate(coinPrefab, randomPos, Quaternion.identity);

            yield return new WaitForSeconds(2);
        }
    }
    IEnumerator EnemySpawnCoroutine()
    {
        while (enemyCount < 50 && playerTransform != null)
        {
            enemyCount++;
            EnemyBehaviour enemy = Instantiate(enemyPrefab, 
                                           spawnPoints[Random.Range(0, spawnPoints.Length)].position, 
                                           Quaternion.identity).GetComponent<EnemyBehaviour>();

            enemy.playerTransform = playerTransform;
            enemy.enemyData = enemyTypes[Random.Range(0, enemyTypes.Length)];

            yield return new WaitForSeconds(5 + enemyCount);
        }    
    }
}
