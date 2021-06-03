using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public int cantidadAgua = 0;
    public List<GameObject> contenido;
    public int crearAmoxicilina;
    bool tomarVaso;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Agua"))
        {
            cantidadAgua++;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Atomo"))
        {
            contenido.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }

        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    tomarVaso = true;
        //}
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        //if (other.CompareTag("Player"))
        //{
        //    tomarVaso = false;
        //}
    }

    private void Update()
    {
        //if (tomarVaso)
        //{
        //    if (Input.GetKeyDown(KeyCode.G))
        //    {
        //        Inventario.intance.inventario.Add(gameObject);
        //        gameObject.SetActive(false);
        //    }
        //}
        for (int i = 0; i < contenido.Count; i++)
        {
            if (contenido[i].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && cantidadAgua >= 15)
            {
                contenido.Remove(contenido[i]);
                crearAmoxicilina = 100;
                Debug.Log("TirateRata");
            }
        }

        if (cantidadAgua >= 15)
        {
             gameObject.GetComponent<SpriteRenderer>().color= Color.blue;
        }
    }
       
}
