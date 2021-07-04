using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorial : MonoBehaviour
{
    public List<string> dialogues;
    public bool derecha;
    public float time;
    private DialogueSistem dialogeSistem;
    private void Start()
    {
        dialogeSistem = FindObjectOfType<DialogueSistem>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1f;
            GameManager.instance.canPause = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            GameManager.instance.canPause = false;
            if (derecha)
            {
                GameManager.instance.canPause = false;
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.DERECHA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
                StartCoroutine(TimingStop());
            }
            else
            {
                GameManager.instance.canPause = false;
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.IZQUIERDA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
                StartCoroutine(TimingStop());
                
            }
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueSistem.instance.HideDialogue();
            GameManager.instance.canPause = true;
            gameObject.SetActive(false);
        }
    }

    IEnumerator TimingStop()
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0f;
    }
}
