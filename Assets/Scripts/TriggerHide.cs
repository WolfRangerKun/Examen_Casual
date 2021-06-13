using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerHide : MonoBehaviour
{
    public static TriggerHide intance;
    public bool isTriggerArriba;
    public GameObject entrada, salida;

    private void Awake()
    {
        intance = this;
    }
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

            if (!isTriggerArriba)
            {
                StartCoroutine(TiempoSetActivesExit());
            }
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTriggerArriba)
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.HIDE;
            StartCoroutine(TiempoSetActivesEntry());
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
