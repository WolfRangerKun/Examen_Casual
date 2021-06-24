using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOffManager : MonoBehaviour
{
    public static SwitchOnOffManager intance;
    // Agua
    public bool isButtonAgua;
    public GameObject agua, spawnAgua;
    public bool aguaGO;
    public SpriteRenderer buttonAgua;
    public List<Sprite> spriteBotonAgua;
    //Fuego
    public bool isButtonFuego;
    public bool fuegoGO;
    public GameObject fuego;
    public SpriteRenderer buttonFuego;
    public List<Sprite> spriteBotonFuego;
    public GameObject mechero;

    private void Awake()
    {
        intance = this;
    }
    private void Start()
    {
        buttonAgua.sprite = spriteBotonAgua[0];
        buttonFuego.sprite = spriteBotonFuego[0];

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (isButtonAgua)
            {
                ActiveAgua();
            }
            if (isButtonFuego)
            {
                ActiveFuego();
            }

        }
       
    }
    void ActiveAgua()
    {
        aguaGO = !aguaGO;

        if (aguaGO)
        {
            StartCoroutine(DispensarAgua());
            buttonAgua.sprite = spriteBotonAgua[1];
        }
        else
        {
            buttonAgua.sprite = spriteBotonAgua[0];
        }

        return;
    }

    void ActiveFuego()
    {
        fuegoGO = !fuegoGO;

        if (fuegoGO)
        {
            mechero.GetComponent<Animator>().SetBool("On", true);
            fuego.SetActive(true);
            buttonFuego.sprite = spriteBotonFuego[1];
        }
        else
        {
            mechero.GetComponent<Animator>().SetBool("On", false);
            fuego.SetActive(false);
            buttonFuego.sprite = spriteBotonFuego[0];
        }
        return;
    }

    IEnumerator DispensarAgua()
    {
        while (aguaGO)
        {
            Instantiate(agua, spawnAgua.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
    private void Awa()
    {
        Instantiate(agua, spawnAgua.transform.position, Quaternion.identity);
    }
}
