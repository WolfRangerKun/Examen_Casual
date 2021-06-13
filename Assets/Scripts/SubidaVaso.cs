using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    public bool paArriba, paAsbajo, entradaObjetoAbajo, salidaObjetoAbajo, cosaPlayer;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (paArriba)
        {
            if (other.CompareTag("Vaso"))
            {
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
            }
            if (other.CompareTag("Atomo"))
            {
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
                TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
            }
        }


        if (paAsbajo)
        {
            if (other.CompareTag("Vaso"))
            {
                TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
            }
            if (other.CompareTag("Atomo"))
            {
                TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
                other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
            }
        }

        if (entradaObjetoAbajo)
        {
            if ((other.CompareTag("Vaso") || other.CompareTag("Atomo")))
            {
                TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
            }
        }

        if (salidaObjetoAbajo)
        {
            if ((other.CompareTag("Vaso") || other.CompareTag("Atomo")))
            {
                TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
            }
        }

        if (other.CompareTag("Player") && cosaPlayer)
        {
            Debug.Log("porno");
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
    
}
