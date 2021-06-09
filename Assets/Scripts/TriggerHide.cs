using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHide : MonoBehaviour
{
    public bool isTriggerArriba;
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.SHOW;
            if (isTriggerArriba)
            {
                CollisionEntrySecondFlor.intanse.triggerArriba.SetActive(false);
                CollisionEntrySecondFlor.intanse.triggerAbajo.SetActive(true);
            }
        }

        if (other.CompareTag("Vaso"))
        {
            for (int i = 0; i < Vaso.intance.contenido.Count; i++)
            {
                if(Vaso.intance.contenido[i].gameObject.name != "Vaso" && isTriggerArriba)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                }
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vaso"))
        {

        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTriggerArriba)
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.HIDE;
        }

        if (other.CompareTag("Vaso"))
        {
            if (isTriggerArriba)
            {
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
        }
    }
}
