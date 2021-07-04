using System.Collections.Generic;
using UnityEngine;

public class ChangeColorVaso : MonoBehaviour
{
    public static ChangeColorVaso intance;
    public List<Sprite> spritesLevelWater;
    public Vaso vaso;
    Sprite actualSprite;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            vaso.ActualizarLista();
        }
    }

    public void CambiarColorDeSprites()
    {
       
        if (vaso.cantidadAgua < 5)//Condicional de cantidad de Agua
        {
            Switch(1);
        }
        else if (vaso.cantidadAgua >= 5 && vaso.cantidadAgua < 10)
        {
            Switch(2);
        }
        else if (vaso.cantidadAgua >= 10 && vaso.cantidadAgua < 15)
        {
            Switch(3);
        }
        else if (vaso.cantidadAgua >= 15)
        {
            Switch(3);
        }
    }

    void Switch(int x)
    {
        Color colorAgua = new Color(0, 0.3421257f, 1, 0.5882353f);
        Color colorCarbonoAgua = new Color(1, 0, 0, 0.5882353f); //Rojo
        Color colorOxigenoAgua = new Color(0.372549f, 0.8039216f, 0.8941177f, 0.5882353f); // Azul
        Color colorMercurioAgua = new Color(1, 1, 0, 0.5882353f); //  Amarillo
        Color colorCarbonoMercurio = new Color(1, 0.5019608f, 0, 0.5882353f); //Naranja
        Color colorCarbonoOxigeno = new Color(0.5019608f, 0, 1, 0.5882353f); // Violeta
        Color colorOxigenoMercurio = new Color(0, 1, 0, 0.5882353f); //Verde
        //Orden
        Color colorMercurioCarbonoOxigeno = new Color(0.4666667f, 0.7921569f, 0.08627451f, 0.5882353f); //AmarilloVerdoso
        Color colorMercurioOxigenoCarbono = new Color(0.4823529f, 0.2705882f, 0, 0.5882353f); //Cafe

        Color colorCarbonoMercurioOxigeno = new Color(0.7921569f, 0.08627451f, 0.3921569f, 0.5882353f); //RojoViolaceo;
        Color colorCarbonoOxigenoMercurio = new Color(1, 0.7019608f, 0.6627451f, 0.5882353f); //EntreRojoyPiel

        Color colorOxigenoCarbonoMercurio = new Color(0, 0, 0.3098039f, 0.7843137f); //AzulMarino
        Color colorOxigenoMercurioCarbono = new Color(0.4784314f, 0.5176471f, 0.2784314f, 0.7843137f); //VerdePalta


        switch (x)
        {
            case 1:
                GetComponent<SpriteRenderer>().sprite = spritesLevelWater[0];//Sprite a Poner

                if (vaso.cantidadAgua == 0 && vaso.contenido.Count == 0)//Segunda limitante
                {
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
                }
                else
                {
                    if (vaso.cantidadAgua > 0 && vaso.contenido.Count == 0)
                    {
                        GetComponent<SpriteRenderer>().color = colorAgua;  // Color agua Sola
                    }
                    else
                    {
                        if (vaso.contenido.Count != 0)
                        {
                            if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
                            {
                                if (vaso.cantidadAgua == 0)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                        //Color De vaso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigenoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurioOxigeno;
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                        {

                                            GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoOxigenoMercurio;
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoMercurioOxigeno;
                                            //Color con el Tercer
                                        }
                                    }
                                }
                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {
                                if (vaso.cantidadAgua == 0)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoCarbonoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurioCarbono;
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorOxigenoAgua;
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorOxigenoCarbonoMercurio;
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorOxigenoMercurioCarbono;
                                            //Color con el Tercer
                                        }
                                    }
                                }
                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {
                                if (vaso.cantidadAgua == 0)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioCarbonoOxigeno;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioOxigenoCarbono;
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorMercurioAgua;
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorMercurioCarbonoOxigeno;
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                        {
                                            GetComponent<SpriteRenderer>().color = colorMercurioOxigenoCarbono;
                                            //Color con el Tercer
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = spritesLevelWater[1];//Sprite a Poner
                if (vaso.cantidadAgua == 5 && vaso.contenido.Count == 0)//Segunda limitante
                {
                    GetComponent<SpriteRenderer>().color = colorAgua;// Color agua
                }
                else
                {
                    if (vaso.cantidadAgua > 5 && vaso.contenido.Count == 0)
                        GetComponent<SpriteRenderer>().color = colorAgua;//Color agua
                    else
                    {
                        if (vaso.contenido.Count != 0)
                        {
                            if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
                            {

                                if (vaso.cantidadAgua >= 5 && vaso.cantidadAgua < 10)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigenoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurioOxigeno;
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {

                                if (vaso.cantidadAgua >= 5 && vaso.cantidadAgua < 10)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoCarbonoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurioCarbono;
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {

                                if (vaso.cantidadAgua >= 5 && vaso.cantidadAgua < 10)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioCarbonoOxigeno;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioOxigenoCarbono;
                                        //Color con el Tercer
                                    }
                                }

                            }
                        }
                    }
                }
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = spritesLevelWater[2];//Sprite a Poner
                if (vaso.cantidadAgua == 10 && vaso.contenido.Count == 0)//Segunda limitante
                {
                    GetComponent<SpriteRenderer>().color = colorAgua;
                }
                else
                {
                    if (vaso.cantidadAgua > 10 && vaso.contenido.Count == 0)
                        GetComponent<SpriteRenderer>().color = colorAgua;
                    else
                    {
                        if (vaso.contenido.Count != 0)
                        {
                            if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO)
                            {

                                if (vaso.cantidadAgua >= 10 /*&& vaso.cantidadAgua < 15*/)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigenoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurioOxigeno;
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {

                                if (vaso.cantidadAgua >= 10 /*&& vaso.cantidadAgua < 15*/)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoOxigeno;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoCarbonoMercurio;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurioCarbono;
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {

                                if (vaso.cantidadAgua >= 10/* && vaso.cantidadAgua < 15*/)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioAgua;
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorOxigenoMercurio;
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioCarbonoOxigeno;
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorMercurioOxigenoCarbono;
                                        //Color con el Tercer
                                    }
                                }

                            }
                        }
                    }
                }
                break;
        }
    }
}
