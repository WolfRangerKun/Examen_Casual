using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    public bool layerMayor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") || collision.CompareTag("Vaso") || collision.CompareTag("Atomo"))
        {
            if (layerMayor)
            {
                collision.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 4;
            }
            else
            {
                collision.gameObject.GetComponentInChildren<SpriteRenderer>().sortingOrder = 0;
            }
                
        }
        
    }
}
