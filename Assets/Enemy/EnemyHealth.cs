using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoint=5;
    [SerializeField] int currentHitPoint=0; 
    Enemy enemy;

    void OnEnable()
    {
        currentHitPoint=maxHitPoint;
    }

    void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    void OnParticleCollision(GameObject other){
        ProcessHit();
    }

    void ProcessHit(){
        currentHitPoint--;
        if(currentHitPoint<=0){
            gameObject.SetActive(false);
            enemy.RewardGold();
        }
    }
}
