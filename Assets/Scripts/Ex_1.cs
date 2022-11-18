using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_1 : MonoBehaviour
{
    private Ex1_1 manager;

    private void Start()
    {
        // We acces the main script
        manager = FindObjectOfType<Ex1_1>();
    }

    // If the mouse is over the GameObject 
    private void OnMouseDown()
    {
        //We add point 
        manager.AddPoint();

        //Destroy the sphere
        Destroy(gameObject);
    }
}