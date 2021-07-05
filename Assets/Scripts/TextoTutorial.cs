using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextoTutorial : MonoBehaviour
{
    public List<string> dialogues;
    public Image objetoTutorial;
    public bool derecha, image;
    public float time = 0.7f;
    private DialogueSistem dialogeSistem;
    private void Start()
    {
        dialogeSistem = FindObjectOfType<DialogueSistem>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameManager.instance.canPause = true;
            //DialogueSistem.finishPremise = true;
            DialogueSistem.instance.HideDialogue();
            if (Time.timeScale == 0f)
            {
                Time.timeScale = 1f;
            }

        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            TextoTutorialPremisa.instance.canPauseTrue = false;
            GameManager.instance.canPause = false;
            if (derecha)
            {
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.DERECHA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
                //DialogueSistem.finishPremise = false;
                StartCoroutine(TimingStop());
                if (image) objetoTutorial.gameObject.SetActive(true);
            }
            else
            {
                dialogeSistem.panelDirection = DialogueSistem.PanelDirection.IZQUIERDA;
                DialogueSistem.instance.ShowDialogue(dialogues[0]);
                //DialogueSistem.finishPremise = false;
                StartCoroutine(TimingStop());
                if (image) objetoTutorial.gameObject.SetActive(true);
            }
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            TextoTutorialPremisa.instance.canPauseTrue = true;
            if (image) objetoTutorial.gameObject.SetActive(false);
            Time.timeScale = 1f;
            DialogueSistem.instance.HideDialogue();
            gameObject.SetActive(false);
        }
    }

    IEnumerator TimingStop()
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = 0f;
    }
}
