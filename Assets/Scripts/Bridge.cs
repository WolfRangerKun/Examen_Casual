using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public GameManager game;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bridges"))
        {
            collision.transform.position = gameObject.transform.position;
            collision.gameObject.layer = 3;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            game.pieceBridges++;
            if(game.pieceBridges == 3)
            {
                collision.gameObject.layer = 0;
            }
        }
    }
}
