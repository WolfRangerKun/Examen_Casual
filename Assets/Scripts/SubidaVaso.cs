using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    public TransparenciaSegundoNivel thisTransparencia;
    public bool paArriba, paAsbajo, entradaObjetoAbajo, salidaObjetoAbajo, cosaPlayer;
    private void OnTriggerEnter2D(Collider2D other)
    {//aca
        if (paArriba)
        {
            if (other.CompareTag("Vaso"))
            {
                if(/*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxVaso < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
                    other.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Add(other.gameObject);
                }
            }
            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxOxigeno < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Add(other.gameObject);
                }

                if (other.name == "Mercurio" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxMercurio < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Add(other.gameObject);
                }

                if (other.name == "Carbono" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxCarbono < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Add(other.gameObject);
                }

            }
        }


        if (paAsbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                //if (TransparenciaSegundoNivel.intanse.maxVaso < 1)

                /* TransparenciaSegundoNivel.intanse*/
                thisTransparencia.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                other.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
                /*TransparenciaSegundoNivel.intanse*/
                thisTransparencia.maxVaso = 0;
                
            }
            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxOxigeno = 0;
                }

                if (other.name == "Mercurio")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxMercurio = 0;
                }

                if (other.name == "Carbono")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /* TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxCarbono = 0;
                }
            }
        }
        //y aca
        if (entradaObjetoAbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                if (/*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxVaso < 1)
                {
                    /* TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    other.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
                }
            }

            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxOxigeno < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }

                if (other.name == "Mercurio" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxMercurio < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }

                if (other.name == "Carbono" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxCarbono < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                
            }

            if (other.CompareTag("Bridges"))
            {
                if (other.name == "Bridge" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxBrige1 < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                if (other.name == "Bridge (1)" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxBrige2 < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                if (other.name == "Bridge (2)" && /*TransparenciaSegundoNivel.intanse*/thisTransparencia.maxBrige3 < 1)
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Add(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
            }
        }

        if (salidaObjetoAbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                //if (TransparenciaSegundoNivel.intanse.maxVaso < 1)

                /* TransparenciaSegundoNivel.intanse*/
                thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                other.gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
                /*TransparenciaSegundoNivel.intanse*/
                thisTransparencia.maxVaso = 0;
                
            }

            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxOxigeno = 0;
                }

                if (other.name == "Mercurio")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxMercurio = 0;
                }

                if (other.name == "Carbono")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /* TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxCarbono = 0;
                }
            }

            if (other.CompareTag("Bridges"))
            {
                if (other.name == "Bridge")
                {
                    /* TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxBrige1 = 0;
                }
                if (other.name == "Bridge (1)")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxBrige2 = 0;
                }
                if (other.name == "Bridge (2)")
                {
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.objectosAbajo.Remove(other.gameObject);
                    //other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    /*TransparenciaSegundoNivel.intanse*/
                    thisTransparencia.maxBrige3 = 0;
                }
            }
        }

        if (other.CompareTag("Player") && cosaPlayer)
        {
            foreach (GameObject g in /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba)
            {
                g.SetActive(false);
            }

            foreach (GameObject g in /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosAbajo)
            {
                g.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && cosaPlayer)
        {

            foreach (GameObject g in /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba)
            {
                g.SetActive(true);
            }
            foreach (GameObject g in /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosAbajo)
            {
                g.SetActive(false);
            }
            if (/*TransparenciaSegundoNivel.intanse*/thisTransparencia.fireInScene)
            {
                if (SwitchOnOffManager.intance.fuegoGO == false)
                {
                    for (int i = 0; i < /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba.Count; i++)
                    {
                        if (/*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba[i].gameObject.name == "Fuego")
                        {
                            Debug.Log("Funciono2");
                            /*TransparenciaSegundoNivel.intanse*/
                            thisTransparencia.objectosArriba[i].gameObject.SetActive(false);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < /*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba.Count; i++)
                    {
                        if (/*TransparenciaSegundoNivel.intanse*/thisTransparencia.objectosArriba[i].gameObject.name == "Fuego")
                        {
                            /*TransparenciaSegundoNivel.intanse*/
                            thisTransparencia.objectosArriba[i].gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }

}
