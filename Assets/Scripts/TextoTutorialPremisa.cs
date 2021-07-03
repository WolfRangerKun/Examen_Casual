using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorialPremisa : MonoBehaviour
{
    public List<string> dialogues;
    public int textoPremisaNumers;
    private DialogueSistem dialogeSistem;
    public PlayerMovement playerMovement;
    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        playerMovement.canMove = false;
    }
    private void Start()
    {
        dialogeSistem = FindObjectOfType<DialogueSistem>();
        
    }

    // Update is called once per frame
    void Update()
    {
        DialogueSistem.instance.ShowDialogueTutorial(dialogues[0]);
        if (Input.GetKeyDown(KeyCode.Return))
        {
            textoPremisaNumers++;
        }
        if(textoPremisaNumers == 1) DialogueSistem.instance.ShowDialogueTutorial(dialogues[1]);
        if(textoPremisaNumers == 2) DialogueSistem.instance.ShowDialogueTutorial(dialogues[2]);
        if(textoPremisaNumers == 3) DialogueSistem.instance.ShowDialogueTutorial(dialogues[3]);
        if (textoPremisaNumers == 4)
        {
            DialogueSistem.instance.HideDialogue();
            DialogueSistem.finishPremise = true;
            textoPremisaNumers = 5;
            playerMovement.canMove = true;
        }

        
    }
}
