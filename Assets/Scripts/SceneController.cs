using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject iguana;
    private GameObject[] lizardHouse = { };
    private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);
    private Vector3 iguanaHangout = new Vector3(-7.39f, 0, -17f);
     private int maxEnemies = 1;
    GameObject[] numEnemies;
    void Start()
    {
        IguanaTimeBaby();
    }
    private void IguanaTimeBaby()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject temp = Instantiate(iguana) as GameObject;
            temp.transform.position = iguanaHangout;
            temp.transform.Rotate(0, Random.Range(0, 360), 0);
            lizardHouse.Append(temp);
        }
    }
    void Update()
    {
        numEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (numEnemies.Length < maxEnemies)
        {
            enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.transform.position = spawnPoint;
            float angle = Random.Range(0, 360);
            enemy.transform.Rotate(0, angle, 0);

        }
    }
}
