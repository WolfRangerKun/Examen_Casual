using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public bool gameRunning;
    int tiempo = 120000;
    //public TMP_Text txtTimer;

    private void Start()
    {
        StartCoroutine(Tiempo());
        gameRunning = true;
        Time.timeScale = 1f;
    }

    void Update()
    {
        //txtTimer.text = "Timer " + tiempo;
        if (tiempo <= 0)
        {
            Debug.Log("Se acabo el Tiempo mano");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ChangedGameRunningState();
        }
    }

    IEnumerator Tiempo()
    {
        while (tiempo > 0)
        {
            yield return new WaitForSeconds(1);
            tiempo--;
        }
    }

    public void ChangedGameRunningState()
    {
        gameRunning = !gameRunning;

        if (gameRunning)
        {
            Time.timeScale = 1f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Play();
            }
        }
        else
        {
            Time.timeScale = 0f;

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
            }
        }
    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
}
