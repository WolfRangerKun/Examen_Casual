using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesa : MonoBehaviour
{
    public List<GameObject> mesa;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Inventario inventario = other.GetComponent<Inventario>();
            foreach (GameObject g in inventario.inventario)
            {
                inventario.inventario.Remove(g);
                mesa.Add(g);
                return;
            }
        }
    }
    
}
