using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);
    [SerializeField] private int maxEnemies = 3;
    private int enemiesSpawned = 0;
    void Start()
    {
        
    }

    void Update()
    {
        GameObject[] numEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemy == null || numEnemies.Length < maxEnemies)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = spawnPoint;
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);

        }
    }
}
