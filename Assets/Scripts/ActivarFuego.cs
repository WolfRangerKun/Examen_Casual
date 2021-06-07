using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarFuego : MonoBehaviour
{
    bool fuegoGO;
    public GameObject fuego;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ActiveFuego();
        }
    }

    void ActiveFuego()
    {
        fuegoGO = !fuegoGO;

        if (fuegoGO)
        {
            fuego.SetActive(true);
        }
        else
        {
            fuego.SetActive(false);
        }
        return;
    }
}
