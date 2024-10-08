﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]
public class CoordinateLabeler : MonoBehaviour
{
    [SerializeField] Color defaultColor = Color.white;
    [SerializeField] Color blockedColor = Color.red;

    TextMeshPro label;
    Vector2Int coordinates = new Vector2Int();
    Waypoint waypoint;

    void Awake() {
        label = GetComponent<TextMeshPro>();
        label.enabled=false;
        waypoint = GetComponentInParent<Waypoint>();
        DisplayCoordinates();
    }

    void Update()
    {
       if(!Application.isPlaying)
       {
           DisplayCoordinates();
           UpdateObjectName();
       } 
       ToggleLabels();
       ColorCoordinates();
    }


    void ToggleLabels(){
        if(Input.GetKeyDown(KeyCode.C)){
            label.enabled=!label.IsActive();
        }
    }

    void ColorCoordinates(){
        if(!waypoint.IsPlaceable){
            label.color=blockedColor;
        }
        else{
            label.color=defaultColor;
        }
    }

    void DisplayCoordinates() 
    {
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        label.text = coordinates.x + "," + coordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = coordinates.ToString();
    }
}
