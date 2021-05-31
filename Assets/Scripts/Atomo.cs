using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atomo : MonoBehaviour
{
    public enum TIPO_ATOMO
    {
        CARBONO = 0,
        OXIGENO = 1,
    }
    public TIPO_ATOMO tipoAtomo;

    private void Start()
    {
        //tipoMolecula = (TIPO_MOLECULA)Random.Range(0, 3);
        ActualizarColor();
    }
    public void ActualizarColor()
    {
        //GetComponent<SpriteRenderer>().color = Color.yellow;

        switch (tipoAtomo)
        {
            case TIPO_ATOMO.CARBONO:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case TIPO_ATOMO.OXIGENO:
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
