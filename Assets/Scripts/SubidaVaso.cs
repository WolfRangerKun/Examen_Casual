using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vaso"))
        {
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
        }
    }
}
