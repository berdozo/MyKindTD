using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlaceable;
    [SerializeField] GameObject towerPrefab;

    public bool IsPlaceable{
        get{
            return isPlaceable;
        }
    }

    void OnMouseDown(){
        if(isPlaceable){
            if(towerPrefab!=null){
                Instantiate(towerPrefab,transform.position,Quaternion.identity);
                isPlaceable=false;
            }
        }
        
    }
}
