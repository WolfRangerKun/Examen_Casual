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
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isTriggerArriba)
        {
            TransparenciaSegundoNivel.intanse.modo = TransparenciaSegundoNivel.MODO.HIDE;
        }
    }
}
