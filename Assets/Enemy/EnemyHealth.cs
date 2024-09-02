using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoint=5;
    [SerializeField] int currentHitPoint=0; 

    void Start()
    {
        currentHitPoint=maxHitPoint;
    }

    void OnParticleCollision(GameObject other){
        ProcessHit();
    }

    void ProcessHit(){
        currentHitPoint--;
        if(currentHitPoint<=0){
            Destroy(gameObject);
        }
    }
}
