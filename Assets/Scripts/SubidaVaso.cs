using UnityEngine;

public class SubidaVaso : MonoBehaviour
{
    public bool paArriba, paAsbajo;
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

    }
}
