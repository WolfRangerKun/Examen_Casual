using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public int escena;
    public Color[] colores;
    public Image botonImage;
    public bool seleccionado;
    public bool botonRei, botonSalir, botonNormal;
    void Start()
    {
        botonImage = GetComponent<Image>();
        botonImage.color = colores[0];
    }

    // Update is called once per frame
    private void Update()
    {
        if (seleccionado)
        {
            botonImage.color = colores[1];
        }
        else
        {
            botonImage.color = colores[0];
        }

        if (Input.GetKeyDown(KeyCode.Return) && seleccionado)
        {
            if (botonRei)
            {
                ChangeScene.intance.ReiniciarEscena();
            }
            if (botonSalir)
            {
                ChangeScene.intance.QuitGame();
            }
            if (botonNormal)
            {
                ChangeScene.intance.CargarNivel(escena);
            }
        }


    }
    private void FixedUpdate()
    {
        //if (seleccionado)
        //{
        //    botonImage.color = colores[1];
        //}
        //else
        //{
        //    botonImage.color = colores[0];
        //}

        //if(Input.GetKeyDown(KeyCode./*Return*/Q) && seleccionado)
        //{
        //    if (botonRei)
        //    {
        //        ChangeScene.instance.ReiniciarEscena();
        //    }
        //    if (botonSalir)
        //    {
        //        ChangeScene.instance.QuitGame();
        //    }
        //    else
        //    ChangeScene.instance.CargarNivel(escena);
        //}

        
    }
}
