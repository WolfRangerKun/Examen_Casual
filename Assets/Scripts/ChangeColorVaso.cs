using System.Collections.Generic;
using UnityEngine;

public class ChangeColorVaso : MonoBehaviour
{
    public List<Sprite> spritesLevelWater;
    public Vaso vaso;
    Sprite actualSprite;
    public bool soloAgua = true;
    // Update is called once per frame
    void Update()
    {
        CambiarColorDeSprites();
    }

    void CambiarColorDeSprites()
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
                        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
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
                                        Debug.LogWarning("ColorCarbonoSolo");
                                        //Color De Baso Con el Primer Elemnto
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
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
                }
                else
                {
                    if (vaso.cantidadAgua > 5 && vaso.contenido.Count == 0)
                        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
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
                    GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
                }
                else
                {
                    if (vaso.cantidadAgua > 10 && vaso.contenido.Count == 0)
                        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
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
