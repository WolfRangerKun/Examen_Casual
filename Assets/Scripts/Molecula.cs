using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Molecula : MonoBehaviour
{
    public enum TIPO_ATOMO
    {
        DIOXIDO = 0,
        ACIDOCARBONICO =1
    }
    public TIPO_ATOMO tipoMolecula;

    private void Start()
    {
        //tipoMolecula = (TIPO_MOLECULA)Random.Range(0, 3);
        ActualizarMolecula();
    }
    public void ActualizarMolecula()
    {
        //GetComponent<SpriteRenderer>().color = Color.yellow;

        switch (tipoMolecula)
        {
            case TIPO_ATOMO.DIOXIDO:
                GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case TIPO_ATOMO.ACIDOCARBONICO:
                GetComponent<SpriteRenderer>().color = Color.cyan;
                break;
        }

    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //tipoMolecula = TIPO_MOLECULA.MADERA;
        }
    }
}
