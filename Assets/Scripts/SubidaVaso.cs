using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    public bool paArriba, paAsbajo, entradaObjetoAbajo, salidaObjetoAbajo, cosaPlayer;
    private void OnTriggerEnter2D(Collider2D other)
    {//aca
        if (paArriba)
        {
            if (other.CompareTag("Vaso"))
            {
                if(TransparenciaSegundoNivel.intanse.maxVaso < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
                }
            }
            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno" && TransparenciaSegundoNivel.intanse.maxOxigeno < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
                }

                if (other.name == "Mercurio" && TransparenciaSegundoNivel.intanse.maxMercurio < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
                }

                if (other.name == "Carbono" && TransparenciaSegundoNivel.intanse.maxCarbono < 1)
                {
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                    TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
                }

            }
        }


        if (paAsbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                //if (TransparenciaSegundoNivel.intanse.maxVaso < 1)
                
                    TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxVaso = 0;
                
            }
            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno")
                {
                    TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxOxigeno = 0;
                }

                if (other.name == "Mercurio")
                {
                    TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxMercurio = 0;
                }

                if (other.name == "Carbono")
                {
                    TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxCarbono = 0;
                }
            }
        }
        //y aca
        if (entradaObjetoAbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                if (TransparenciaSegundoNivel.intanse.maxVaso < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
            }

            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno" && TransparenciaSegundoNivel.intanse.maxOxigeno < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }

                if (other.name == "Mercurio" && TransparenciaSegundoNivel.intanse.maxMercurio < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }

                if (other.name == "Carbono" && TransparenciaSegundoNivel.intanse.maxCarbono < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                
            }

            if (other.CompareTag("Bridges"))
            {
                if (other.name == "Bridge" && TransparenciaSegundoNivel.intanse.maxBrige1 < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                if (other.name == "Bridge (1)" && TransparenciaSegundoNivel.intanse.maxBrige2 < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
                if (other.name == "Bridge (2)" && TransparenciaSegundoNivel.intanse.maxBrige3 < 1)
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                }
            }
        }

        if (salidaObjetoAbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                //if (TransparenciaSegundoNivel.intanse.maxVaso < 1)
                
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxVaso = 0;
                
            }

            if (other.CompareTag("Atomo"))
            {
                if (other.name == "Oxigeno")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxOxigeno = 0;
                }

                if (other.name == "Mercurio")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxMercurio = 0;
                }

                if (other.name == "Carbono")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxCarbono = 0;
                }
            }

            if (other.CompareTag("Bridges"))
            {
                if (other.name == "Bridge")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxBrige1 = 0;
                }
                if (other.name == "Bridge (1)")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxBrige2 = 0;
                }
                if (other.name == "Bridge (2)")
                {
                    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
                    other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
                    TransparenciaSegundoNivel.intanse.maxBrige3 = 0;
                }
            }
        }

        if (other.CompareTag("Player") && cosaPlayer)
        {
            foreach (GameObject g in TransparenciaSegundoNivel.intanse.objectosArriba)
            {
                g.SetActive(false);
            }
            foreach (GameObject g in TransparenciaSegundoNivel.intanse.objectosAbajo)
            {
                g.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && cosaPlayer)
        {
            foreach (GameObject g in TransparenciaSegundoNivel.intanse.objectosArriba)
            {
                g.SetActive(true);
            }
            foreach (GameObject g in TransparenciaSegundoNivel.intanse.objectosAbajo)
            {
                g.SetActive(false);
            }
        }
    }

}
