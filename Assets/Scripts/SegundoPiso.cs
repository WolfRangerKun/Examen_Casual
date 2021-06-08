using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPiso : MonoBehaviour
{
    public PlayerMovement player;
    public bool stayPiso2;
    public List<GameObject> off;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.distanceRayCollision = 0.1f;
            off[0].GetComponent<EdgeCollider2D>().isTrigger = true;
            off[1].GetComponent<EdgeCollider2D>().isTrigger = true;
            off[2].GetComponent<EdgeCollider2D>().isTrigger = true;
            off[3].GetComponent<EdgeCollider2D>().isTrigger = true;
            stayPiso2 = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.distanceRayCollision = 1f;
            off[0].GetComponent<EdgeCollider2D>().isTrigger = false;
            off[1].GetComponent<EdgeCollider2D>().isTrigger = false;
            off[2].GetComponent<EdgeCollider2D>().isTrigger = false;
            off[3].GetComponent<EdgeCollider2D>().isTrigger = false;
            stayPiso2 = false;

        }
        
    }
}
