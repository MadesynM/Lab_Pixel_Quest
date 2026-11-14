using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geo_Controller : MonoBehaviour
{
    public int variable1 = 2;
    // Start is called before the first frame update
    private string Var2 = "Hello";
    int varOne = 5;
    private Rigidbody2D rb;
    private SpriteRenderer _spriteRenderer;
    public float xMultiplier = 4;
    public string nextLevel = "Lvl2";
    // Capsule
    public float CapsuleHeight = 0.25f; 
    public float CapsuleRadius = 0.08f;

    // Ground Chek 
    public Transform feetCollider;
    public LayerMask groundMask; 
    public float jumpForce = 5f;
    private GameObject grabbedObject;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = transform.GetChild(0).GetComponent<SpriteRenderer >();
       // Debug.Log(Var2 + "World");

    }

    // Update is called once per frame
    void Update()
    {
        // Checks if player is touching ground
        Collider2D  hit = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(CapsuleHeight, CapsuleRadius), CapsuleDirection2D.Horizontal,
            0, groundMask);


        if (hit != null)
        {
            grabbedObject = hit.gameObject;
            if(Input.GetKeyDown(KeyCode.H))
            {
                Destroy(grabbedObject.gameObject);
            }
        }
        // Checks if player is trying to jump/can jump
        if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector2 (rb.velocity.x, jumpForce);
        }

        float xMovement = Input.GetAxis("Horizontal");
            xMovement *= variable1;
            rb.velocity = new Vector2(xMovement, rb.velocity.y);
            //Debug.Log(xInput);
            if (xMovement < 0) { _spriteRenderer.flipX = false;}
            else if (xMovement > 0) { _spriteRenderer.flipX = true;}
        
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
            {
               case "Death":
                   {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                   }
               case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
    
            }
    }
}
