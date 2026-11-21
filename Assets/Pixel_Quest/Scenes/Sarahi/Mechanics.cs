using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private int coinCounter = 0;
    private int _health = 3;
    private int _maxHealth = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }
            case "Health":
                {
                    _health++;
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
