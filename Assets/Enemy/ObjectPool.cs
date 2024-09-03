using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] float spawnTime = 1f;

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }



    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            Instantiate(enemy,transform);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
