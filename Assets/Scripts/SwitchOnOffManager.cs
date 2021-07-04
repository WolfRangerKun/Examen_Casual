using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOffManager : MonoBehaviour
{
    public static SwitchOnOffManager intance;
    public AudioSource buttomSound;
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
        if (isButtonAgua)
        {
            buttonAgua.sprite = spriteBotonAgua[0];
        }
        if (isButtonFuego)
        {
            buttonFuego.sprite = spriteBotonFuego[0];
        }

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
        buttomSound.Play();
        if (aguaGO)
        {
            StartCoroutine(DispensarAgua());
            buttonAgua.sprite = spriteBotonAgua[1];
        }
        else
        {
            StopCoroutine(DispensarAgua());
            buttonAgua.sprite = spriteBotonAgua[0];
        }

        return;
    }
    public bool haveMechero;
    void ActiveFuego()
    {
        fuegoGO = !fuegoGO;
        buttomSound.Play();
        if (fuegoGO)
        {
            if (haveMechero)
                mechero.GetComponent<Animator>().SetBool("On", true);
            fuego.SetActive(true);
            buttonFuego.sprite = spriteBotonFuego[1];
        }
        else
        {
            if (haveMechero)
                mechero.GetComponent<Animator>().SetBool("On", false);
            fuego.SetActive(false);
            buttonFuego.sprite = spriteBotonFuego[0];
        }
        return;
    }

    public IEnumerator DispensarAgua()
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
