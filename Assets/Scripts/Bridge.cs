using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public BridgeManager game;
    public bool lateral;
    public AudioSource sonidoCheck;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bridges"))
        {
            sonidoCheck.Play();
            if (lateral)
            {
                collision.gameObject.GetComponent<Objeto>().contacts[0].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[1].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[4].SetActive(true);
            }
            else
            {
                collision.gameObject.GetComponent<Objeto>().contacts[2].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[3].SetActive(false);
            }
            //collision.gameObject.GetComponent<Objeto>().enabled = false;
            collision.transform.position = gameObject.transform.position;
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            collision.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 2;
            collision.gameObject.layer = 3;
            collision.gameObject.layer = 0;
            gameObject.SetActive(false);
        }
    }
}
