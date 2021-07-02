using System.Collections.Generic;
using UnityEngine;

public class ChangeColorVaso : MonoBehaviour
{
    public static ChangeColorVaso intance;
    public List<Sprite> spritesLevelWater;
    public Vaso vaso;
    Sprite actualSprite;
    public bool soloAgua = true;
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
        Color colorOxigenoAgua = new Color(0, 0, 1, 0.5882353f); // Azul
        Color colorMercurioAgua = new Color(0, 1, 0, 0.5882353f); //  Amarillo
        Color colorCarbonoMercurio = new Color(1, 0.5019608f, 0, 0.5882353f); //Naranja
        Color colorCarbonoOxigeno = new Color(0.5019608f, 0, 1, 0.5882353f); // Violeta
        Color colorOxigenoMercurio = new Color(0, 1, 0, 0.5882353f); //Verde
        
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
                                        Debug.LogWarning("ColorCarbonoSolo");
                                        //Color De vaso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            Debug.LogWarning("ColorCarbonoSoloConAgua");
                                            GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
                                        GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.5882353f);
                                        Debug.LogWarning("ColorCarbonoSolo");
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            Debug.LogWarning("ColorCarbonoSoloConAgua");
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
                                        Debug.LogWarning("ColorCarbonoSolo");
                                        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 0.5882353f);
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSolo");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioSolo");
                                        //Color con el Tercer
                                    }

                                }
                                else
                                {
                                    if (vaso.cantidadAgua != 0)
                                    {
                                        if (vaso.contenido.Count == 1)
                                        {
                                            Debug.LogWarning("ColorCarbonoSoloConAgua");
                                            //Color De Baso Con el Primer Elemnto
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                        {

                                            Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                            //Color Con el segundo
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                            //Color con el Tercer
                                        }
                                        else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                        {
                                            Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.5882353f);
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 0.5882353f);
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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

                                if (vaso.cantidadAgua >= 10 && vaso.cantidadAgua < 15)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        GetComponent<SpriteRenderer>().color = colorCarbonoAgua;
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO)
                            {

                                if (vaso.cantidadAgua >= 10 && vaso.cantidadAgua < 15)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 0.5882353f);
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                }

                            }
                            else if (vaso.contenido[0].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.MERCURIO)
                            {

                                if (vaso.cantidadAgua >= 10 && vaso.cantidadAgua < 15)
                                {
                                    if (vaso.contenido.Count == 1)
                                    {
                                        Debug.LogWarning("ColorCarbonoSoloConAgua");
                                        GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 0.5882353f);
                                        //Color De Baso Con el Primer Elemnto
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[1].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 2)
                                    {

                                        Debug.LogWarning("ColorCarbonoOxigenoSoloConAgua");
                                        //Color Con el segundo
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.OXIGENO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
                                        //Color con el Tercer
                                    }
                                    else if (vaso.contenido[2].gameObject.GetComponent<Atomo>().tipoAtomo == Atomo.TIPO_ATOMO.CARBONO && vaso.contenido.Count == 3)
                                    {
                                        Debug.LogWarning("ColorCarbonoOxigenoMercurioConAgua");
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
