using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lupteri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            float xPos = Random.Range(-45, 45);
            float yPos = Random.Range(-10, 28);
            float yVel = Random.Range(-7, 7);
            float xVel = Random.Range(-7, 7);

            if (this.transform.position.y < -6)
            {
                xPos = Random.Range(-50, 50);
                this.transform.position = new Vector2(xPos, 9);

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, yVel);
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                        RaycastHit hit;
                        if (Physics.Raycast(ray, out hit, 100.0f) && hit.transform.gameObject != null)
                        {
                            GameObject.Destroy(hit.transform.gameObject);

                            if (Input.GetKey(KeyCode.Mouse1))
                            {
                                Destroy(gameObject);
                            }
                        }
                    }
                }









                
                    
                    

                }
            }
        }
    }
