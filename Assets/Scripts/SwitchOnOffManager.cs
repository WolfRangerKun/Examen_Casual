using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOnOffManager : MonoBehaviour
{
    // Agua
    public bool isButtonAgua;
    public GameObject agua, spawnAgua;
    public bool aguaGO;
    public SpriteRenderer buttonAgua;
    public List<Sprite> spriteBotonAgua;
    //Fuego
    public bool isButtonFuego;
    bool fuegoGO;
    public GameObject fuego;
    public SpriteRenderer buttonFuego;
    public List<Sprite> spriteBotonFuego;

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
            fuego.SetActive(true);
            buttonFuego.sprite = spriteBotonFuego[1];
        }
        else
        {
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
