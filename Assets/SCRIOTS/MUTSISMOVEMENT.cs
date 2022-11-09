using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUTSISMOVEMENT : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
       
        
    }

    // Update is called once per frame
    void Update() {
        {
        float xPos = Random.range(-12,71, 12,71);

        if(this.transform.position.y < -0,44) {
            xPos = Random.range(-0,44, 10,71);
            this.transform.position = new Vector2(xPos, 0,44)

        }
}
