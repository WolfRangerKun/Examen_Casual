using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenciaSegundoNivel : MonoBehaviour
{
    public static TransparenciaSegundoNivel intanse;
    [Range(0, 1)]
    public float transparencia = 0, transicionSpeed = 1;
    public SpriteRenderer spriteRenderer;
    bool canButton = true;
    public List<GameObject> objectosArriba, objectosAbajo;

    public enum MODO
    {
        SHOW = 0,
        HIDE = 1,
        NOTHING = -1
    }

    public MODO modo;
    private void Awake()
    {
        intanse = this;
    }
    private void Start()
    {
        
        modo = MODO.NOTHING;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(modo.Equals(MODO.HIDE))
        {
            if (transparencia <= 0)
                modo = MODO.NOTHING;

            transparencia -= Time.deltaTime;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            foreach(GameObject g in objectosArriba)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
                g.SetActive(false);
            }

            foreach (GameObject g in objectosAbajo)
            {
                g.SetActive(true);
            }
        }

        if (modo.Equals(MODO.SHOW))
        {
            if (transparencia >= 1)
                modo = MODO.NOTHING;

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
