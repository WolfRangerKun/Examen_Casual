using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorVaso : MonoBehaviour
{
    public List<Sprite> spritesLevelWater;
    Sprite actualSprite;
    public bool soloAgua = true;   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Vaso.intance.ActualizarLista();
        }

        CambiarColorDeSprites();

        //if (Vaso.intance.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
        //{

        //    Debug.Log("Tirate");
        //    // poner que el vaso se pueda tomar  y  desplegar winning del gameManager
        //}
        //else if(Vaso.intance.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
        //{

        //}
        //else if(Vaso.intance.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
        //{

        //}
    }

    void CambiarColorDeSprites()
    {
        if (Vaso.intance.cantidadAgua < 5)//Condicional de cantidad de Agua
        {
            GetComponent<SpriteRenderer>().sprite = spritesLevelWater[0];//Sprite a Poner
            if (Vaso.intance.cantidadAgua == 0 && Vaso.intance.contenido.Count == 0)//Segunda limitante
            {
                
                GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
            }
            else
            {
                if (Vaso.intance.cantidadAgua > 0 && Vaso.intance.contenido.Count == 0)
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                else
                {
                    if(Vaso.intance.contenido.Count != 0)
                    {
                        if (Vaso.intance.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
                        {
                            Debug.LogError("ColorCarbono");
                            if (Vaso.intance.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {
                                //Color Con el segundo
                            }
                            else if (Vaso.intance.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {
                                //Color con el Tercer
                            }
                            else
                                GetComponent<SpriteRenderer>().color = new Color(0.75f, 1, 1, 1);
                            //Color De Baso Con el Primer Elemnto
                        }
                        else if (Vaso.intance.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                        {
                            Debug.LogError("ColorOxigeno");
                            if (Vaso.intance.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {
                                //Color Con el segundo
                            }
                            else if (Vaso.intance.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {
                                //Color con el Tercer
                            }
                            else
                                GetComponent<SpriteRenderer>().color = new Color(0.75f, 1, 1, 1);
                            //Color De Baso Con el Primer Elemnto
                        }
                        else if (Vaso.intance.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                        {
                            Debug.LogError("ColorMercurio");
                            if (Vaso.intance.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {
                                //Color Con el segundo
                            }
                            else if (Vaso.intance.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {
                                //Color con el Tercer
                            }
                            else
                                GetComponent<SpriteRenderer>().color = new Color(0.75f, 1, 1, 1);
                            //Color De Baso Con el Primer Elemnto
                        }
                    }
                   
                }
               
            }
        }
        //else if (Vaso.intance.cantidadAgua >= 5 && Vaso.intance.cantidadAgua < 10)
        //{
        //   GetComponent<SpriteRenderer>().sprite = spritesLevelWater[0];
        //    GetComponent<SpriteRenderer>().color = new Color(0.75f, 1, 1, 1);
        //}
        //else if (Vaso.intance.cantidadAgua >= 10 && Vaso.intance.cantidadAgua < 15)
        //{
        //    GetComponent<SpriteRenderer>().sprite = spritesLevelWater[1];
        //    GetComponent<SpriteRenderer>().color = new Color(0.5f, 1, 1, 1);
        //}
        //else if (Vaso.intance.cantidadAgua >= 15)
        //{
        //    GetComponent<SpriteRenderer>().sprite = spritesLevelWater[2];
        //    GetComponent<SpriteRenderer>().color = new Color(0, 1, 1, 1);
        //}
    }

    void Switch(float x)
    {
        switch (x)
        {
            case 0.1f:

                break;
        }
    }
}
