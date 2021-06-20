using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPiso : MonoBehaviour
{
    public PlayerMovement player;
    public bool stayPiso2;
    public List<GameObject> off;
    public bool puente;
    public Objeto obj;

    public void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        obj = FindObjectOfType<Objeto>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player.distanceRayCollision = 0.1f;
            off[0].layer = 0;
            off[1].layer = 0;
            off[2].layer = 0;
            off[3].layer = 0;
            stayPiso2 = true;
            if (puente) off[4].layer = 0;
        }
        if (collision.gameObject.layer == 6 && collision.CompareTag("Atomo") || collision.CompareTag("Vaso") || collision.CompareTag("Bridges"))
        {
            obj.primerPiso = false;
            obj.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //player.distanceRayCollision = 1f;
            off[0].layer = 3;
            off[1].layer = 3;
            off[2].layer = 3;
            off[3].layer = 3;
            stayPiso2 = false;
            if (puente) off[4].layer = 3;
        }
        if (collision.gameObject.layer == 6 && collision.CompareTag("Atomo") || collision.CompareTag("Vaso") || collision.CompareTag("Bridges"))
        {
            obj.primerPiso = true;
            obj.enabled = true;
        }


    }
}
