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
    public bool canPause = true;
    bool run = true;
    public bool tutorial;
    Button buton;
    public GameObject spawnAgua;
    PlayerMovement playerMovement;
    public bool finishlvl;
    public AudioSource clockLoop;
    private void Awake()
    {
        instance = this;
        playerMovement = FindObjectOfType<PlayerMovement>();
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
            if (tiempo <= 30 && tiempo > 10)
            {
                clockLoop.pitch = 1.3f;
            }
            else if (tiempo <= 10 && tiempo > 5)
            {
                clockLoop.pitch = 1.6f;
            }
            else if (tiempo <= 5)
            {
                clockLoop.pitch = 1.8f;
            }
            txtTimer.text = tiempo.ToString();
            yield return new WaitForSeconds(1);
            if (tutorial)
                if(DialogueSistem.finishPremise || DialogueSistem1.finishPremise)
                tiempo--;
            if(!tutorial)
                tiempo--;
        }

    }
    bool isOnFire, isOnWater;
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
            if (isOnFire == false)
            {
                SwitchOnOffManager.intance.fuego.SetActive(false);
            }
            else if (isOnFire == true)
            {
                SwitchOnOffManager.intance.fuego.SetActive(true);
            }

            if (isOnWater == false)
            {
                SwitchOnOffManager.intance.aguaGO = false;
            }
            else if (isOnWater == true)
            {
                SwitchOnOffManager.intance.aguaGO = true;
            }
            ChangeScene.intance.musicaNivel.Play();
            clockLoop.Play();
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
            if (SwitchOnOffManager.intance.fuegoGO == false)
            {
                SwitchOnOffManager.intance.fuego.SetActive(false);
                isOnFire = false;
            }
            else if(SwitchOnOffManager.intance.fuegoGO == true)
            {
                SwitchOnOffManager.intance.fuego.SetActive(false);
                isOnFire = true;
            }

            if (SwitchOnOffManager.intance.aguaGO == false)
            {
                SwitchOnOffManager.intance.aguaGO = false;
                isOnWater = false;
            }
            else if (SwitchOnOffManager.intance.aguaGO == true)
            {
                SwitchOnOffManager.intance.aguaGO = false;
                isOnWater = true;
            }
            ChangeScene.intance.musicaNivel.Pause();
            clockLoop.Pause();        
        }
    }

    public bool IsGameRunning()
    {
        return gameRunning;
    }
    public IEnumerator WinningChoose()
    {
        finishlvl = true;
        playerMovement.canMove = false;
        SwitchOnOffManager.intance.fuego.SetActive(false);
        spawnAgua.SetActive(false);
        StopCoroutine(SwitchOnOffManager.intance.DispensarAgua());
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        clockLoop.volume = 0;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        reproductor.clip = videosWinLose[1];
        rawVideo.SetActive(true);
        reproductor.Play();
        yield return new WaitForSeconds(6.5f);
        botonWin = true;
        screenWin.SetActive(true);
       
    }
    public IEnumerator LoseChoose()
    {
        finishlvl = true;
        playerMovement.canMove = false;
        SwitchOnOffManager.intance.fuego.SetActive(false);
        spawnAgua.SetActive(false);
        StopCoroutine(SwitchOnOffManager.intance.DispensarAgua());
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        clockLoop.volume = 0;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        reproductor.clip = videosWinLose[0];
        rawVideo.SetActive(true);
        reproductor.Play();
        yield return new WaitForSeconds(6.5f);
        botonLose = true;
        screenDead.SetActive(true);

    }
    public IEnumerator LoseTimer()
    {
        finishlvl = true;
        playerMovement.canMove = false;
        SwitchOnOffManager.intance.fuego.SetActive(false);
        spawnAgua.SetActive(false);
        StopCoroutine(SwitchOnOffManager.intance.DispensarAgua());
        txtTimer.gameObject.SetActive(false);
        canPause = false;
        clockLoop.volume = 0;
        StartCoroutine(FadeOut(ChangeScene.intance.musicaNivel, 1));
        yield return new WaitForSeconds(.5f);
        reproductor.clip = videosWinLose[2];
        rawVideo.SetActive(true);
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

    public IEnumerator VideoPremisa()
    {
        canPause = false;
        rawVideo.SetActive(true);
        PlayerMovement.instace.canMove = false;
        reproductor.clip = videosWinLose[3];
        reproductor.Play();
        yield return new WaitForSeconds(3.5f);
        rawVideo.SetActive(false);
    }
}
