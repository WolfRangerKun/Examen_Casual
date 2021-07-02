using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTutorial : MonoBehaviour
{
    public List<string> dialogues;
    public bool derecha;
    public int time;
    private DialogueSistem dialogeSistem;
    public GameObject premisa;
    private void Start()
    {
        dialogeSistem = FindObjectOfType<DialogueSistem>();
        Destroy(premisa, 4);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1f;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (derecha)
            {
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.DERECHA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
                StartCoroutine(TimingStop());
            }
            else
            {
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
        }
    }

    IEnumerator TimingStop()
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0f;
    }
}
