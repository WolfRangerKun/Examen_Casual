using System.Collections.Generic;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public int cantidadAgua = 0;
    public List<GameObject> contenido;
    public int crearAmoxicilina;
    bool tomarVaso;

    public bool nivel1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Agua"))
        {
            cantidadAgua++;
            Destroy(other.gameObject);
            ActualizarLista();

        }
        if (other.CompareTag("Atomo"))
        {
            contenido.Add(other.gameObject);
            other.gameObject.SetActive(false);
            ActualizarLista();
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

    }


    void ActualizarLista()
    {
        if (cantidadAgua >= 15)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (nivel1)
        {
            if (contenido.Count == 3)
            {
                if (cantidadAgua >= 15)
                {
                    if (contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                    {
                        contenido.Remove(contenido[0]);
                        contenido.Remove(contenido[0]);
                        contenido.Remove(contenido[0]);
                        crearAmoxicilina = 100;
                        Debug.Log("Tirate");
                    }
                    else
                    {
                        Debug.Log("Tefolta");
                    }

                }
            }

            //for (int i = 0; i < contenido.Count; i++)
            //{
            //    //if(contenido.Count == 3)
            //    //{
            //    //    if(cantidadAgua >= 15)
            //        {
            //            if (contenido[i].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
            //            {
            //                i = 0;
            //                contenido.Remove(contenido[i]);
            //                crearAmoxicilina = 100;
            //                Debug.Log("Tirate");
            //            }
            //            if (contenido[i].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
            //            {
            //                i = 1;
            //                contenido.Remove(contenido[i]);
            //                crearAmoxicilina = 100;
            //                Debug.Log("Rata");
            //            }
            //            if (contenido[i].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
            //            {
            //                i = 2;
            //                contenido.Remove(contenido[i]);
            //                crearAmoxicilina = 100;
            //                Debug.Log("jaja");
            //            }
            //        }
            //    }
            //}
        }
    }

    public enum ORDEN_PRODUCTO
    {
        PRODUCTO1,
        PRODUCTO2,
        PRODUCTO3,
        PRODUCTO4
    }

    void RevisarLista(ORDEN_PRODUCTO oRDEN)
    {
        switch (oRDEN)
        {
            case ORDEN_PRODUCTO.PRODUCTO1:

                break;
        }
    }
}
