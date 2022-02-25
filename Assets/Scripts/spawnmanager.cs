using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefabenemyupr;
    public GameObject[] enemyspawnposupr;
    public GameObject prefabenemyright;
    public GameObject[] enemyspawnposright;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SpawnEnemy()
    {
        for (int i = 0; i < enemyspawnposupr.Length; i++)
        {
            Instantiate(prefabenemyupr, enemyspawnposupr[i].transform.position, prefabenemyupr.transform.rotation);
        }
        for (int j = 0; j < enemyspawnposright.Length; j++)
        {
            Instantiate(prefabenemyright, enemyspawnposright[j].transform.position, prefabenemyright.transform.rotation);
        }

    }
}

