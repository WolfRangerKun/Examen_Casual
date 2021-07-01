using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaso : MonoBehaviour
{
    public static Vaso intance;
    public int cantidadAgua = 0;
    public List<GameObject> contenido;
    public int crearAmoxicilina;
    public int gradosCalor = 0;
    bool tomarVaso;
    public bool haytransparencia = true;

    public bool isNivel1, isNivel2, isNivel3, isNivel4;

    public int maxOxigeno = 0;
    public int maxMercurio = 0;
    public int maxCarbono = 0;

    public ChangeColorVaso changeColorVaso;
    public List<Sprite> spritesContorno;
    public List<Sprite> spriteElementoActual;

    public TransparenciaSegundoNivel MesaTransparencia;
    private void Awake()
    {
        intance = this;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //if (other.CompareTag("Agua"))
        //{
        //    cantidadAgua++;
        //    Destroy(other.gameObject);
        //    ActualizarLista();
        //}


        //if (other.CompareTag("Atomo"))
        //{
        if (other.name == "Oxigeno" && maxOxigeno < 1 && other.CompareTag("Atomo"))
        {
            if (haytransparencia)
            {
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosAbajo.Count; i++)
                {

                    if (TransparenciaSegundoNivel.intanse.objectosAbajo[i].gameObject.name == "Oxigeno")
                    {
                        TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(gameObject);
                        TransparenciaSegundoNivel.intanse.maxOxigeno = 0;
                    }
                }
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosArriba.Count; i++)
                {
                    if (TransparenciaSegundoNivel.intanse.objectosArriba[i].gameObject.name == "Oxigeno")
                    {
                        TransparenciaSegundoNivel.intanse.objectosArriba.Remove(gameObject);
                        TransparenciaSegundoNivel.intanse.maxOxigeno = 0;
                    }
                }
                
            }
            for (int i = 0; i < contenido.Count; i++)
            {
                if (contenido[i].gameObject.name == "Oxigeno")
                {
                    return;
                }
            }
            contenido.Add(other.gameObject);
            other.gameObject.SetActive(false);
            ActualizarLista();
        }

        if (other.name == "Mercurio" && maxMercurio < 1 && other.CompareTag("Atomo"))
        {
            if (haytransparencia)
            {
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosAbajo.Count; i++)
                {
                    if (TransparenciaSegundoNivel.intanse.objectosAbajo[i].gameObject.name == "Mercurio")
                    {
                        TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(gameObject);
                        TransparenciaSegundoNivel.intanse.maxMercurio = 0;
                    }
                }
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosArriba.Count; i++)
                {
                    if (TransparenciaSegundoNivel.intanse.objectosArriba[i].gameObject.name == "Mercurio")
                    {
                        TransparenciaSegundoNivel.intanse.objectosArriba.Remove(gameObject);
                        TransparenciaSegundoNivel.intanse.maxMercurio = 0;
                    }
                }
               
            }
            for (int i = 0; i < contenido.Count; i++)
            {
                if (contenido[i].gameObject.name == "Mercurio")
                {
                    return;
                }
            }

            contenido.Add(other.gameObject);
            other.gameObject.SetActive(false);
            ActualizarLista();
        }

        if (other.name == "Carbono" && maxCarbono < 1 && other.CompareTag("Atomo"))
        {
            if (haytransparencia)
            {
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosAbajo.Count; i++)
                {
                    if (TransparenciaSegundoNivel.intanse.objectosAbajo[i].gameObject.name == "Carbono")
                    {
                        TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(TransparenciaSegundoNivel.intanse.objectosAbajo[i].gameObject);
                        TransparenciaSegundoNivel.intanse.maxCarbono = 0;
                    }

                }
                for (int i = 0; i < TransparenciaSegundoNivel.intanse.objectosArriba.Count; i++)
                {
                    if (TransparenciaSegundoNivel.intanse.objectosArriba[i].gameObject.name == "Carbono")
                    {
                        TransparenciaSegundoNivel.intanse.objectosArriba.Remove(gameObject);
                        TransparenciaSegundoNivel.intanse.maxCarbono = 0;
                    }
                }
                
            }
            for (int i = 0; i < contenido.Count; i++)
            {
                if (contenido[i].gameObject.name == "Carbono")
                {
                    return;
                }
            }
            contenido.Add(other.gameObject);
            other.gameObject.SetActive(false);
            ActualizarLista();
        }

        //}
        if (other.CompareTag("Fuego"))
        {
            StartCoroutine(ContadorFuego());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Fuego"))
        {
            StopCoroutine(ContadorFuego());
        }
    }

    private void Update()
    {
        for (int i = 0; i < contenido.Count; i++)
        {

            if (contenido[i].gameObject.name == "Oxigeno")
            {
                maxOxigeno = 1;
            }
            if (contenido[i].gameObject.name == "Mercurio")
            {
                maxMercurio = 1;
            }
            if (contenido[i].gameObject.name == "Carbono")
            {
                maxCarbono = 1;
            }

        }
    }


    public void ActualizarLista()
    {
        changeColorVaso.CambiarColorDeSprites();
        if (cantidadAgua >= 15)
        {
            //GetComponent<SpriteRenderer>().sprite = spriteElementoActual[1];
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = spriteElementoActual[0];
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

    IEnumerator ContadorFuego()
    {
        while (gradosCalor <= 50)
        {
            yield return new WaitForSeconds(.5f);
            gradosCalor++;
        }

        while (gradosCalor <= 100)
        {
            yield return new WaitForSeconds(.25f);
            gradosCalor++;
        }

        while (gradosCalor <= 130)
        {
            yield return new WaitForSeconds(.125f);
            gradosCalor++;
        }
    }


    public IEnumerator CambiarSpriteMovimiento(int x)
    {
        GetComponent<SpriteRenderer>().sprite = spritesContorno[x];
        yield return new WaitForSeconds(.1f);
        GetComponent<SpriteRenderer>().sprite = spriteElementoActual[x];
    }

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
                           
                            crearAmoxicilina = 100;
                            Debug.Log("Tirate");
                            // poner que el vaso se pueda tomar  y  desplegar winning del gameManager
                        }
                        else
                        {
                            Debug.Log("Tefolta");
                            // poner que el vaso se pueda tomar  y  desplegar lose
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
                        if (gradosCalor >= 120)
                        {
                            if (contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {
                               
                                crearAmoxicilina = 100;
                                Debug.LogError("Tirate");
                            }
                            else
                            {
                                Debug.Log("Tefolta");
                            }
                        }


                    }
                }
                break;
            case ORDEN_PRODUCTO.PRODUCTO4:
                if (contenido.Count == 1)
                {
                    if (cantidadAgua >= 15)
                    {
                        //if (gradosCalor >= 120)
                        //{
                        if (contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
                        {
                            
                            crearAmoxicilina = 100;
                            Debug.Log("Tirate");
                        }
                        else
                        {
                            Debug.Log("Tefolta");
                        }
                        //}

                    }
                }
                break;
        }
    }
}
