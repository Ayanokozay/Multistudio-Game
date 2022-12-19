using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
public static GameObject selectedObject;
 public static GameObject targetObject;
 public static GameObject focusedObject;
 
 private Color originalColor;
 public Color selectedColor = Color.green;
 
 void start()
 {  
     originalColor = GetComponent<Renderer>().material.color;
 }
 void OnMouseEnter()
 {
     GetComponent<Renderer>().material.color = selectedColor;
 }
 void OnMouseOver()
 {
     if (Input.GetMouseButtonUp(0))
     {
         selectedObject = gameObject;
     }
     if (Input.GetMouseButtonDown(1))
     {
         targetObject = gameObject;
     }
     if (Input.GetMouseButtonUp(2))
     {
         focusedObject = gameObject;
     }
 }
 void OnMouseExit()
 {
     GetComponent<Renderer>().material.color = originalColor;
     focusedObject = null;
 }
}