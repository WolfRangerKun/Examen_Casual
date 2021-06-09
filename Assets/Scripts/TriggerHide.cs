using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHide : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.SHOW;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.HIDE;
        }
    }
}
