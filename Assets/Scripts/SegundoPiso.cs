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
            stayPiso2 = true;
            off[0].SetActive(false);
            off[1].SetActive(false);
            off[2].SetActive(false);
            off[3].SetActive(false);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.distanceRayCollision = 1f;
            stayPiso2 = false;
            off[0].SetActive(true);
            off[1].SetActive(true);
            off[2].SetActive(true);
            off[3].SetActive(true);

        }
        
    }
}
