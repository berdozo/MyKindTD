using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{   
    [SerializeField] Transform weapon;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<EnemyMover>().transform;
    }

    

    // Update is called once per frame
    void Update()
    {
        AimWepon();
    }

    void AimWepon()
    {
        weapon.LookAt(target);
    }
}
