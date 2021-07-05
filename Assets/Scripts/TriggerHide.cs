using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerHide : MonoBehaviour
{
    public TransparenciaSegundoNivel thisTransparencia;
    public static TriggerHide intance;
    public bool isTriggerArriba;
    public GameObject entrada, salida;
    public bool existeCollissionEntrySecondFlor;

    private void Awake()
    {
        intance = this;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            /* TransparenciaSegundoNivel.intanse*/
            thisTransparencia.modo = TransparenciaSegundoNivel.MODO.SHOW;
            if (isTriggerArriba)
            {
                if (existeCollissionEntrySecondFlor)
                {
                    CollisionEntrySecondFlor.intanse.triggerArriba.SetActive(false);
                    CollisionEntrySecondFlor.intanse.triggerAbajo.SetActive(true);
                }
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
            }

            if (!isTriggerArriba)
            {
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                StartCoroutine(TiempoSetActivesExit());
            }
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTriggerArriba)
        {
            /*TransparenciaSegundoNivel.intanse*/
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
            thisTransparencia.modo = TransparenciaSegundoNivel.MODO.HIDE;
            StartCoroutine(TiempoSetActivesEntry());
        }
        else
        {
            if(other.CompareTag("Player") && isTriggerArriba)
            {
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            }
        }
    }

    IEnumerator TiempoSetActivesEntry()
    {
        entrada.SetActive(false);
        yield return new WaitForSeconds(.2f);
        salida.SetActive(true);
    }
    IEnumerator TiempoSetActivesExit()
    {
        entrada.SetActive(true);
        yield return new WaitForSeconds(.2f);
        salida.SetActive(false);

    }
}
