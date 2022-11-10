using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour {

    private Vector2 targetPos;
    public float Yincrement;

    public float maxHeight;
    public float minHeight;
    private void Update(float y)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {

            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        } else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
    }
}

 
   
    
        
    


