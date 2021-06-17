using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atomo : MonoBehaviour
{
    public static Atomo intance;
    public Sprite spriteElementoOriginal;
    public List<Sprite> spritesContorno;
    public enum TIPO_ATOMO
    {
        CARBONO = 0,
        OXIGENO = 1,
        MERCURIO =2
    }
    public TIPO_ATOMO tipoAtomo;

    private void Start()
    {
        intance = this;
    }
    public void ActualizarSprite()
    {

        //switch (tipoAtomo)
        //{
        //    case TIPO_ATOMO.CARBONO:
        //        spriteCambiado = spritesContorno[0];
        //        break;
        //    case TIPO_ATOMO.OXIGENO:
        //        spriteCambiado = spritesContorno[1];
        //        break;
        //    case TIPO_ATOMO.MERCURIO:
        //        spriteCambiado = spritesContorno[2];
        //        break;
        //}
    }


    public IEnumerator CambiarSpriteMovimiento()
    {
        switch (tipoAtomo)
        {
            case TIPO_ATOMO.CARBONO:
                GetComponent<SpriteRenderer>().sprite = spritesContorno[0];
                yield return new WaitForSeconds(.1f);
                GetComponent<SpriteRenderer>().sprite = spriteElementoOriginal;
                break;
            case TIPO_ATOMO.OXIGENO:
                GetComponent<SpriteRenderer>().sprite = spritesContorno[1];
                yield return new WaitForSeconds(.1f);
                GetComponent<SpriteRenderer>().sprite = spriteElementoOriginal;
                break;
            case TIPO_ATOMO.MERCURIO:
                GetComponent<SpriteRenderer>().sprite = spritesContorno[2];
                yield return new WaitForSeconds(.1f);
                GetComponent<SpriteRenderer>().sprite = spriteElementoOriginal;
                break;
        }
    }
}
