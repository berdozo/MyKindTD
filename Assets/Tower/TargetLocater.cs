using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{   
    [SerializeField] Transform weapon;
    [SerializeField] float towerRange=15f;
    [SerializeField] ParticleSystem projectileParticles;
    Transform target;

    

    // Update is called once per frame
    void Update()
    {
        TargetClosestEnemy();
        AimWepon();
    }


    void TargetClosestEnemy()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Transform closestEnemy = null;
        float maxDistance = Mathf.Infinity;

        foreach(Enemy enemy in enemies)
        {
            float targetDistance = Vector3.Distance(transform.position,enemy.transform.position);
            
            if(targetDistance<maxDistance)
            {
                closestEnemy = enemy.transform;
                maxDistance = targetDistance;
            }
        }

        target = closestEnemy.transform;
    }

    void AimWepon()
    {
        float targetDistance = Vector3.Distance(transform.position,target.transform.position);
        
        weapon.LookAt(target);

        if(targetDistance<=towerRange)
        {
            Atack(true);
        }
        else
        {
            Atack(false);
        }
    }

    void Atack(bool isActive)
    {
        var emmisionModule = projectileParticles.emission;
        emmisionModule.enabled = isActive;
    }
}
