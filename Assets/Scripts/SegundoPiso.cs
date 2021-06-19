using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPiso : MonoBehaviour
{
    public PlayerMovement player;
    public bool stayPiso2;
    public List<GameObject> off;
    public bool puente,  segundoPisoObjeto;

    public void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.CompareTag("Objeto"))
        {
            //player.distanceRayCollision = 0.1f;
            off[0].layer = 0;
            off[1].layer = 0;
            off[2].layer = 0;
            off[3].layer = 0;
            stayPiso2 = true;
            if (puente) off[4].layer = 0;
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && collision.CompareTag("Objeto"))
        {
            //player.distanceRayCollision = 1f;
            off[0].layer = 3;
            off[1].layer = 3;
            off[2].layer = 3;
            off[3].layer = 3;
            stayPiso2 = false;
            if (puente) off[4].layer = 3;
        }


    }
}
