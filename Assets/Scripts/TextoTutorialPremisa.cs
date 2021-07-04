using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorialPremisa : MonoBehaviour
{
    public List<string> dialogues;
    public int textoPremisaNumers;
    public bool fuego;
    public PlayerMovement playerMovement;
    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerMovement.canMove = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (fuego)
        {
            DialogueSistem1.instance.ShowDialogueTutorial(dialogues[0]);
            playerMovement.canMove = false;
            GameManager.instance.canPause = false;
        }
        else
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[0]);
            playerMovement.canMove = false;
            GameManager.instance.canPause = false;
        }
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            textoPremisaNumers++;
        }
        if (textoPremisaNumers == 1 && !fuego)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[1]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 2 && !fuego) 
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[2]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 3 && !fuego)
        {
            DialogueSistem.instance.ShowDialogueTutorial(dialogues[3]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 4 && !fuego)
        {
            DialogueSistem.instance.HideDialoguePremisa();
            GameManager.instance.canPause = true;
            DialogueSistem.finishPremise = true;
            if(GameManager.instance.canPause == true)
            {
                textoPremisaNumers = 5;
            }
        }
        if(textoPremisaNumers >= 4 && !fuego)
        {
            playerMovement.canMove = true;
        }
        if (textoPremisaNumers == 1 && fuego)
        {
            DialogueSistem1.instance.ShowDialogueTutorial(dialogues[1]);
            GameManager.instance.canPause = false;
        }
        if (textoPremisaNumers == 2 && fuego)
        {
            DialogueSistem1.instance.HideDialogue();
            DialogueSistem1.finishPremise = true;
            textoPremisaNumers = 5;
            playerMovement.canMove = true;
        }
        
    }
}
