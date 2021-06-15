using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenciaSegundoNivel : MonoBehaviour
{
    public static TransparenciaSegundoNivel intanse;
    [Range(0, 1)]
    public float transparencia = 0f, transicionSpeed = 1;
    public SpriteRenderer spriteRenderer;
    bool canButton = true;
    public List<GameObject> objectosArriba, objectosAbajo;
    public int maxVaso = 0;
    public int maxOxigeno = 0;
    public int maxMercurio = 0;
    public int maxCarbono = 0;
    public int maxBrige1 = 0;
    public int maxBrige2 = 0;
    public int maxBrige3 = 0;


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
        foreach (GameObject g in objectosAbajo)
        {
            g.SetActive(false);
        }
    }

    private void Update()
    {
        for (int i = 0; i < objectosAbajo.Count; i++)
        {
            if ((objectosAbajo[i].gameObject.name == "Vaso"))
            {
                maxVaso = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Oxigeno"))
            {
                maxOxigeno = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Mercurio"))
            {
                maxMercurio = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Carbono"))
            {
                maxCarbono = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Bridge"))
            {
                maxBrige1 = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Bridge (1)"))
            {
                maxBrige2 = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Bridge (2)"))
            {
                maxBrige3 = 1;
            }
        }

        for (int i = 0; i < objectosArriba.Count; i++)
        {
            if ((objectosAbajo[i].gameObject.name == "Vaso"))
            {
                maxVaso = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Oxigeno"))
            {
                maxOxigeno = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Mercurio"))
            {
                maxMercurio = 1;
            }
            if ((objectosAbajo[i].gameObject.name == "Carbono"))
            {
                maxCarbono = 1;
            }
        }



        //foreach (GameObject g in objectosAbajo)
        //{
        //}

        if (modo.Equals(MODO.HIDE))
        {
            if (transparencia <= 0.5)
                modo = MODO.NOTHING;

            //transparencia -= Time.deltaTime / 2;
            transparencia = .4f;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            foreach(GameObject g in objectosArriba)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
                g.SetActive(false);
            }

            foreach (GameObject g in objectosAbajo)
            {
                g.SetActive(true);
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            }
        }

        if (modo.Equals(MODO.SHOW))
        {
            if (transparencia >= 1)
                modo = MODO.NOTHING;

            //transparencia += Time.deltaTime / 2;
            transparencia = 1f;
            spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            foreach (GameObject g in objectosAbajo)
            {
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
                g.SetActive(false);
            }

            foreach (GameObject g in objectosArriba)
            {
                g.SetActive(true);
                spriteRenderer.color = new Color(spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, transparencia);
            }
        }
    }

    public void Activate()
    {
        canButton = true;
    }
}
