using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "_New Enemy", menuName = "_Enemy")]
public class EnemyData : ScriptableObject
{
    public string enemyName;
    public Material enemyMaterial;
    public int health;
    public int speed;

    public void Print()
    {
        Debug.Log("This is a method in a scriptable object");
    }
}
