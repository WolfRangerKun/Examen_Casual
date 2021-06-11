using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public BridgeManager game;
    public int bridge;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bridges"))
        {
            collision.transform.position = gameObject.transform.position;
            collision.gameObject.layer = 3;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            if (bridge == 1) game.active1 = true;
            if (bridge == 2 )game.active2 = true;
            if (bridge == 3) game.active3 = true;
            collision.gameObject.layer = 0;
            gameObject.SetActive(false);
        }
    }
}
