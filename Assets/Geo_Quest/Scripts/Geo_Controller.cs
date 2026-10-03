using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geo_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    private string Var2 = "Hello";
    int varOne = 5;
    private Rigidbody2D rb;
    
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log(Var2 + "World");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            rb.velocity = new Vector2(1, rb.velocity.y);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
       
    }
         /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            transform.position += new Vector3(0, -2, 0);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, 2, 0);
        }
        Debug.Log(varOne);
        varOne++;*/
    
}
       

