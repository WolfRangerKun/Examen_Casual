using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorial : MonoBehaviour
{
    public List<string> dialogues;
    public bool derecha;
    private DialogueSistem dialogeSistem;
    private void Start()
    {
        dialogeSistem = FindObjectOfType<DialogueSistem>();
    }
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (derecha)
            {
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.DERECHA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
            }
            else
            {
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.IZQUIERDA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
            }
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
