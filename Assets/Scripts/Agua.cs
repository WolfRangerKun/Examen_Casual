using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
     AudioSource sonidoAgua;
    void Start()
    {
        sonidoAgua = GetComponent<AudioSource>();
        Destroy(gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vaso"))
        {
            sonidoAgua.Play();
            other.GetComponent<Vaso>().cantidadAgua++;
            Destroy(gameObject, 0.1f);
            other.GetComponent<Vaso>().ActualizarLista();
        }
        else
            return;
    }
    void Update()
    {

    }
}
