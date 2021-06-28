using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static GameManager instance;
    public bool gameRunning;
    int tiempo = 120;
    public bool botonWin, botonLose, boton;
    public TMP_Text txtTimer;
    public GameObject screenPause, screenDead, screenWin;
    bool canPause = true;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(Tiempo());
        gameRunning = true;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (tiempo <= 0)
        {
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.volume = .5f;
            }
            canPause = false;
            botonLose = true;
            screenDead.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            ChangedGameRunningState();
        }
    }

    IEnumerator Tiempo()
    {
        while (tiempo > 0)
        {
            txtTimer.text = "Tiempo: " + tiempo.ToString();
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
            screenPause.SetActive(false);
            boton = false;
            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Play();
            }
        }
        else
        {
            Time.timeScale = 0f;
            screenPause.SetActive(true);
            boton = true;
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
    IEnumerator WINNING()
    {
        canPause = false;
        Debug.Log("oli");
        botonWin = true;
        screenWin.SetActive(true);
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.volume = .5f;
        }
        yield return new WaitForSeconds(.1f);
    }
}
