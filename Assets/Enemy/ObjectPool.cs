using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    [SerializeField] GameObject enemy;
    [SerializeField] int poolSize = 5;
    [SerializeField] float spawnTime = 1f;

    GameObject[] pool;

    void Awake()
    {
        PopulatePool();
    }

    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    void PopulatePool()
    {
        pool = new GameObject[poolSize];

        for(int i=0;i< pool.Length;i++)
        {
            pool[i]=Instantiate(enemy,transform);
            pool[i].SetActive(false);
        }
    }

    void EnableObjectInPool(){
        for(int i=0;i<pool.Length;i++)
        {
            if(!pool[i].activeSelf)
            {
                pool[i].SetActive(true);
                return;
            }
            
        }
    }

    IEnumerator SpawnEnemy()
    {
        while(true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
