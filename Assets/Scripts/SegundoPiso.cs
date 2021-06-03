using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPiso : MonoBehaviour
{
    public PlayerMovement player;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.distanceRayCollision = 0.1f;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.distanceRayCollision = 1f;
        }
        
    }
}
