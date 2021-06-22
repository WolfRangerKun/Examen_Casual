using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesManager : MonoBehaviour
{
    public Botones[] botones, botonesMuerte,botonesWin;
    public int pocision, posicionWin, posicionLose;

    bool muerte, win, normal;

    public bool isMenu;
    void Start()
    {

    }

    public enum LISTABOTONES {
        botones, botonesMuerte, botonesWin
    }

    public LISTABOTONES tipoBotones;
     
    private void Update()
    {
        if (!isMenu)
        {
            if (GameManager.instance.boton == true)
            {
                tipoBotones = LISTABOTONES.botones;
            }

            if (GameManager.instance.botonLose == true)
            {
                tipoBotones = LISTABOTONES.botonesMuerte;
            }

            if (GameManager.instance.botonWin == true)
            {
                tipoBotones = LISTABOTONES.botonesWin;
            }
        }

        CambioBotones();

    }
    void CambioBotones(/*LISTABOTONES tipobotones*/)
    {
        //tipobotones = tipoBotones;
        switch (tipoBotones)
        {
            case LISTABOTONES.botones:
                if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                    botones[pocision].seleccionado = false;
                    pocision++;

                    if (pocision < 0)
                    {
                        pocision = botones.Length - 1;
                        botones[pocision].seleccionado = true;
                        return;
                    }

                    if (pocision > botones.Length - 1)
                    {
                        pocision = 0;
                        botones[pocision].seleccionado = true;
                        return;
                    }

                    botones[pocision].seleccionado = true;
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    botones[pocision].seleccionado = false;
                    pocision--;

                    if (pocision < 0)
                    {
                        pocision = botones.Length - 1;
                        botones[pocision].seleccionado = true;
                        return;
                    }

                    if (pocision >= botones.Length - 1)
                    {
                        pocision = 0;
                        botones[pocision].seleccionado = true;
                        return;
                    }

                    botones[pocision].seleccionado = true;
                }
                break;

            case LISTABOTONES.botonesWin:
                if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                    botonesWin[posicionWin].seleccionado = false;
                    posicionWin++;

                    if (posicionWin < 0)
                    {
                        posicionWin = botonesWin.Length - 1;
                        botonesWin[posicionWin].seleccionado = true;
                        return;
                    }

                    if (posicionWin > botonesWin.Length - 1)
                    {
                        posicionWin = 0;
                        botonesWin[posicionWin].seleccionado = true;
                        return;
                    }

                    botonesWin[posicionWin].seleccionado = true;
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    botonesWin[posicionWin].seleccionado = false;
                    posicionWin--;

                    if (posicionWin < 0)
                    {
                        posicionWin = botonesWin.Length - 1;
                        botonesWin[posicionWin].seleccionado = true;
                        return;
                    }

                    if (posicionWin >= botonesWin.Length - 1)
                    {
                        posicionWin = 0;
                        botonesWin[posicionWin].seleccionado = true;
                        return;
                    }

                    botonesWin[posicionWin].seleccionado = true;
                }
                break;

            case LISTABOTONES.botonesMuerte:
                if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.DownArrow))
                {
                    botonesMuerte[posicionLose].seleccionado = false;
                    posicionLose++;

                    if (posicionLose < 0)
                    {
                        posicionLose = botonesMuerte.Length - 1;
                        botonesMuerte[posicionLose].seleccionado = true;
                        return;
                    }

                    if (posicionLose > botonesMuerte.Length - 1)
                    {
                        posicionLose = 0;
                        botonesMuerte[posicionLose].seleccionado = true;
                        return;
                    }

                    botonesMuerte[posicionLose].seleccionado = true;
                }

                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow))
                {
                    botonesMuerte[posicionLose].seleccionado = false;
                    posicionLose--;

                    if (posicionLose < 0)
                    {
                        posicionLose = botonesMuerte.Length - 1;
                        botonesMuerte[posicionLose].seleccionado = true;
                        return;
                    }

                    if (posicionLose >= botonesMuerte.Length - 1)
                    {
                        posicionLose = 0;
                        botonesMuerte[posicionLose].seleccionado = true;
                        return;
                    }

                    botonesMuerte[posicionLose].seleccionado = true;
                }
                break;
        }

    }
    // Update is called once per frame
   
}
