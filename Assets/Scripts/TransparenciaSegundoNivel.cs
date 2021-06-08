using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenciaSegundoNivel : MonoBehaviour
{
    [Range(0, 1)]
    public float transparencia = 0, transicionSpeed = 1;
    public SpriteRenderer spriteRenderer;
    bool canButton = true;
    public List<GameObject> objectosArriba, objectosAbajo;

    public enum Modo
    {
        SHOW = 0,
        HIDE = 1,
        NOTHING = -1
    }

    public Modo modo;

    private void Start()
    {
        modo = Modo.NOTHING;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(modo.Equals(Modo.HIDE))
        {
            if (transparencia <= 0)
                modo = Modo.NOTHING;

            transparencia -= Time.deltaTime * 2;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            foreach(GameObject g in objectosArriba)
            {
                g.SetActive(false);
            }

            foreach (GameObject g in objectosAbajo)
            {
                g.SetActive(true);
            }
        }

        if (modo.Equals(Modo.SHOW))
        {
            if (transparencia >= 1)
                modo = Modo.NOTHING;

            transparencia += Time.deltaTime / 2;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            foreach (GameObject g in objectosAbajo)
            {
                g.SetActive(false);
            }

            foreach (GameObject g in objectosArriba)
            {
                g.SetActive(true);
            }
        }
    }

    public void Activate()
    {
        canButton = true;
    }
}
