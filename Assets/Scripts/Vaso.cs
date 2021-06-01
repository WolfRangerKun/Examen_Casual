using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public int cantidadAgua = 0;
    bool tomarVaso;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Agua"))
        {
            if (cantidadAgua < 4)
            {
                cantidadAgua++;
                Destroy(other.gameObject);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tomarVaso = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            tomarVaso = false;
        }
    }

    private void Update()
    {
        if (tomarVaso)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Inventario.intance.inventario.Add(gameObject);
                gameObject.SetActive(false);
            }
        }
    }
}
