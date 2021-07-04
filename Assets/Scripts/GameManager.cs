using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static GameManager instance;
    public bool gameRunning;
    public int tiempo = 120;
    public Slider tiempoSlider;
    public bool botonWin, botonLose, boton;
    public TMP_Text txtTimer;
    public GameObject screenPause, screenDead, screenWin, rawVideo;
    public VideoPlayer reproductor;
    public List<VideoClip> videosWinLose;
    bool canPause = true;
    bool run = true;
    public bool tutorial;
    Button buton;

    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        reproductor.clip = null;
        StartCoroutine(Tiempo());
        gameRunning = true;
        Time.timeScale = 1f;
        tiempoSlider.maxValue = tiempo;
        tiempoSlider.value = tiempo;

    }

    void Update()
    {
        Cursor.visible = false;
        if (tiempo <= 0 && run)
        {
            StartCoroutine(LoseTimer());
            run = false;
            //AudioSource[] audios = FindObjectsOfType<AudioSource>();
            //foreach (AudioSource a in audios)
            //{
            //    a.volume = .5f;
            //}
            //canPause = false;
            //botonLose = true;
            //screenDead.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && canPause)
        {
            ChangedGameRunningState();
        }
        tiempoSlider.value = tiempo;
    }

    IEnumerator Tiempo()
    {
        while (tiempo > 0)
        {
            txtTimer.text = tiempo.ToString();
            yield return new WaitForSeconds(1);
            if (tutorial)
                if(DialogueSistem.finishPremise || DialogueSistem1.finishPremise)
                tiempo--;
            if(!tutorial)
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
            //AudioSource[] audios = FindObjectsOfType<AudioSource>();
            //foreach (AudioSource a in audios)
            //{
            //    a.Play();
            //}
            ChangeScene.intance.musicaNivel.Play();
        }
        else
        {
            Time.timeScale = 0f;
            screenPause.SetActive(true);
            boton = true;
            //AudioSource[] audios = FindObjectsOfType<AudioSource>();
            //foreach (AudioSource a in audios)
            //{
            //    a.Pause();
            //}
            ChangeScene.intance.musicaNivel.Pause();
        }
    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
    public IEnumerator WinningChoose()
    {
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        rawVideo.SetActive(true);
        reproductor.clip = videosWinLose[1];
        reproductor.Play();
        yield return new WaitForSeconds(6.5f);
        botonWin = true;
        screenWin.SetActive(true);
       
    }
    public IEnumerator LoseChoose()
    {
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        rawVideo.SetActive(true);
        reproductor.clip = videosWinLose[0];
        reproductor.Play();
        yield return new WaitForSeconds(6.5f);
        botonLose = true;
        screenDead.SetActive(true);

    }
    public IEnumerator LoseTimer()
    {
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        rawVideo.SetActive(true);
        reproductor.clip = videosWinLose[2];
        reproductor.Play();
        yield return new WaitForSeconds(7f);
        botonLose = true;
        screenDead.SetActive(true);

    }

    public  IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;

            yield return null;
        }

        audioSource.Stop();
        audioSource.volume = startVolume;
    }
}
