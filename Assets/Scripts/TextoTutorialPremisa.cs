using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoTutorialPremisa : MonoBehaviour
{
    public static TextoTutorialPremisa instance;
    public List<string> dialogues;
    public Image vasoPrecipitado, teclas1, teclas2;
    public int textoPremisaNumers;
    public bool fuego;
    public bool canPauseTrue = true;
    public PlayerMovement playerMovement;
    private void Awake()
    {
        instance = this;
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerMovement.canMove = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (fuego && !GameManager.instance.finishlvl)
        {
            playerMovement.canMove = false;
            DialogueSistem1.instance.ShowDialogueTutorial(dialogues[0]);
            GameManager.instance.canPause = false;
        }
        if(!fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[0]);
            playerMovement.canMove = false;
            GameManager.instance.canPause = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            textoPremisaNumers++;
        }
        if (textoPremisaNumers == 1 && !fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[1]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 2 && !fuego && !GameManager.instance.finishlvl) 
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[2]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 3 && !fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[3]);
            vasoPrecipitado.gameObject.SetActive(true);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 4 && !fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[4]);
            vasoPrecipitado.gameObject.SetActive(false);
            teclas1.gameObject.SetActive(true);
            teclas2.gameObject.SetActive(true);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers >= 5 && !fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem.instance.HideDialoguePremisa();
            playerMovement.canMove = true;
            DialogueSistem.finishPremise = true;
            
        }
        if(textoPremisaNumers >= 5 && !fuego && canPauseTrue && !GameManager.instance.finishlvl)
        {
            GameManager.instance.canPause = true;
        }
        if (textoPremisaNumers == 1 && fuego && !GameManager.instance.finishlvl)
        {
            DialogueSistem1.instance.ShowDialogueTutorial(dialogues[1]);
            vasoPrecipitado.gameObject.SetActive(true);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers >= 2 && fuego && !GameManager.instance.finishlvl)
        {
            playerMovement.canMove = true;
            
            DialogueSistem1.instance.HideDialogue();
            GameManager.instance.canPause = true;
            DialogueSistem1.finishPremise = true;
            
        }
        
    }
}
