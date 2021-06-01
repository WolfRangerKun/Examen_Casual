using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecula : MonoBehaviour
{
    public enum TIPO_ATOMO
    {
        DIOXIDO = 0,
    }
    public TIPO_ATOMO tipoMolecula;

    private void Start()
    {
        //tipoMolecula = (TIPO_MOLECULA)Random.Range(0, 3);
        ActualizarColor();
    }
    public void ActualizarColor()
    {
        //GetComponent<SpriteRenderer>().color = Color.yellow;

        switch (tipoMolecula)
        {
            case TIPO_ATOMO.DIOXIDO:
                GetComponent<SpriteRenderer>().color = Color.blue;
                break;
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //tipoMolecula = TIPO_MOLECULA.MADERA;
            ActualizarColor();
        }
    }
}
