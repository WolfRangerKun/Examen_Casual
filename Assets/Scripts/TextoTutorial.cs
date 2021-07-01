using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorial : MonoBehaviour
{
    public List<string> dialogues;

    public void OnTriggerStay2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            DialogueSistem.instance.ShowDialogue(dialogues[0]);

        }
    }


    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueSistem.instance.HideDialogue();
        }
    }
}
