using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    public bool paArriba, paAsbajo, entradaObjetoAbajo, salidaObjetoAbajo;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Vaso") && paArriba)
        {
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
        }

        if (other.CompareTag("Vaso") && paAsbajo)
        {
            TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }

        if (other.CompareTag("Atomo") && paArriba)
        {
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
            TransparenciaSegundoNivel.intanse.objectosArriba.Add(other.gameObject);
        }

        if (other.CompareTag("Atomo") && paAsbajo)
        {
            TransparenciaSegundoNivel.intanse.objectosArriba.Remove(other.gameObject);
            other.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 0;
        }

        //if((other.CompareTag("Vaso") || other.CompareTag("Atomo")) && entradaObjetoAbajo)
        //{
        //    TransparenciaSegundoNivel.intanse.objectosAbajo.Add(other.gameObject);
        //}

        //if ((other.CompareTag("Vaso") || other.CompareTag("Atomo")) && salidaObjetoAbajo)
        //{
        //    TransparenciaSegundoNivel.intanse.objectosAbajo.Remove(other.gameObject);
        //}
    }
}
