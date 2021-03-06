using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPiso : MonoBehaviour
{
    public PlayerMovement player;
    public bool stayPiso2;
    public List<GameObject> off;
    public List<GameObject> libro;
    public GameObject piezaPuente;
    public GameObject enterDosD;
    public bool puente, libroRojo, nivel3;

    public void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            off[0].layer = 0;
            off[1].layer = 0;
            off[2].layer = 0;
            off[3].layer = 0;
            stayPiso2 = true;
            if (puente) off[4].layer = 0;
            if (libroRojo)
            {
                libro[0].SetActive(false); // abajo
                libro[1].SetActive(true); // arriba
                if (nivel3)
                {
                    
         
                }
            }
            if (nivel3 && piezaPuente.gameObject.activeSelf == false)
            {
                libro[2].SetActive(false);
            }
            collision.GetComponent<SpriteRenderer>().sortingOrder = 3;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            off[0].layer = 3;
            off[1].layer = 3;
            off[2].layer = 3;
            off[3].layer = 3;
            stayPiso2 = true;
            if (puente) off[4].layer = 3;
            if (libroRojo)
            {
                libro[0].SetActive(true);
                libro[1].SetActive(false);
                
            }
            if (nivel3 && piezaPuente.gameObject.activeSelf == false)
            {
                libro[2].SetActive(true);
            }
            if (nivel3)
            {
                enterDosD.SetActive(true);
                gameObject.SetActive(false);
            }

            collision.GetComponent<SpriteRenderer>().sortingOrder = 0;

            
        }
       
    }
}
