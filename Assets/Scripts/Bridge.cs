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
                collision.gameObject.GetComponent<Objeto>().contacts[2].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[3].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[4].SetActive(true);
            }
            else
            {
                collision.gameObject.GetComponent<Objeto>().contacts[0].SetActive(true);
                collision.gameObject.GetComponent<Objeto>().contacts[0].GetComponentInChildren<GrabOutCollision>().enabled = false;
                collision.gameObject.GetComponent<Objeto>().contacts[0].GetComponentInChildren<BoxCollider2D>().enabled = false;
                collision.gameObject.GetComponent<Objeto>().contacts[1].SetActive(true);
                collision.gameObject.GetComponent<Objeto>().contacts[1].GetComponentInChildren<GrabOutCollision>().enabled = false;
                collision.gameObject.GetComponent<Objeto>().contacts[1].GetComponentInChildren<BoxCollider2D>().enabled = false;
                collision.gameObject.GetComponent<Objeto>().contacts[2].SetActive(false);
                collision.gameObject.GetComponent<Objeto>().contacts[3].SetActive(false);
                collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            collision.gameObject.GetComponent<Objeto>().enabled = false;
            collision.transform.position = gameObject.transform.position;
            collision.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 1;
            collision.gameObject.layer = 3;
            gameObject.SetActive(false);
        }
    }
}
