using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPlayerLayer : MonoBehaviour
{
    public GameObject objetosDown;
    public bool isBridge;
    public bool goingUp,goinDown;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //if (goingUp)
            //{
            //    other.GetComponent<SpriteRenderer>().sortingOrder = 2;
            //    objetosDown.SetActive(true);
            //    Debug.Log("OLIWI");

            //}
            //else
            if (goinDown)
            {
                other.GetComponent<SpriteRenderer>().sortingOrder = 0;
                objetosDown.SetActive(false);
            }
        }
        else
            return;
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (goingUp)
            {
                other.GetComponent<SpriteRenderer>().sortingOrder = 3;
                objetosDown.SetActive(true);
            }
            else if (goinDown && isBridge)
            {
                other.GetComponent<SpriteRenderer>().sortingOrder = 0;
            }
        }
        else
            return;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (goingUp)
            {

            }
            else
                if (goinDown)
            {

            }
        }
        else
            return;
    }

    
}
