using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex_3 : MonoBehaviour
{
    //Limits that the player can't pas.
    public float spaceLimits = 3.5f;

    //Distance beetwen the squares.
    public float distance = 1.75f; 
    private Vector3 nextPos;

    void Update()
    {
        //Mecanic movment of the player.
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != spaceLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
            transform.position = nextPos;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -spaceLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);
            transform.position = nextPos;         
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != spaceLimits)
        {
            nextPos = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            transform.position = nextPos;          
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -spaceLimits)
        {
            nextPos = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
            transform.position = nextPos;          
        }
    }
   
}