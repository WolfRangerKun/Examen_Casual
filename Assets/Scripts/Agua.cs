using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 4);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vaso"))
        {
            other.GetComponent<Vaso>().cantidadAgua++;
            Destroy(gameObject);
            other.GetComponent<Vaso>().ActualizarLista();
        }
        else
            return;
    }
    void Update()
    {

    }
}
