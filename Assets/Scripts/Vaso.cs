using System.Collections.Generic;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public int cantidadAgua = 0;
    public List<GameObject> contenido;
    public int crearAmoxicilina;
    bool tomarVaso;

    public bool isNivel1, isNivel2, isNivel3, isNivel4;
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


    private void Update()
    {
        

    }


    void ActualizarLista()
    {
        if (cantidadAgua >= 15)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (isNivel1)
        {
            RevisarLista(ORDEN_PRODUCTO.PRODUCTO1);
        }
        if (isNivel2)
        {
            RevisarLista(ORDEN_PRODUCTO.PRODUCTO2);
        }
        if (isNivel3)
        {
            RevisarLista(ORDEN_PRODUCTO.PRODUCTO3);
        }
        if (isNivel4)
        {
            RevisarLista(ORDEN_PRODUCTO.PRODUCTO4);
        }

    }

    //for (int i = 0; i < contenido.Count; i++)
    //{
    //    
    //            if (contenido[i].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
    //            {
    //                contenido.Remove(contenido[i]);
    //                crearAmoxicilina = 100;
    //                Debug.Log("Tirate");
    //            }
    //            
    //}



    public enum ORDEN_PRODUCTO
    {
        PRODUCTO1,
        PRODUCTO2,
        PRODUCTO3,
        PRODUCTO4
    }

    ORDEN_PRODUCTO oRDEN_PRODUCTO;
    void RevisarLista(ORDEN_PRODUCTO orden)
    {
        switch (orden)
        {
            case ORDEN_PRODUCTO.PRODUCTO1:
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
                break;
            case ORDEN_PRODUCTO.PRODUCTO2:
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
                break;
            case ORDEN_PRODUCTO.PRODUCTO3:
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
                break;
            case ORDEN_PRODUCTO.PRODUCTO4:
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
                break;
        }
    }
}
