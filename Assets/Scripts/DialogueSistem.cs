using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class DialogueSistem : MonoBehaviour
{
    public enum PanelDirection
    {
        DERECHA,
        IZQUIERDA
    }
    public PanelDirection panelDirection;
    public static DialogueSistem instance;
    public TextMeshProUGUI textoDialogo1, textoDialogo2;
    public TextMeshProUGUI textoDialogoPremisa;
    public List<RectTransform> panelDialogo;
    public List<RectTransform> guiaPanel;
    public RectTransform premisa, guiaPremisa;
    private Vector2 originalPositionPremisa;
    private Vector2 originalPos1, originalPos2;
    public static bool finishPremise;
    public GameManager gameManager;
    private void Awake()
    {
        instance = this;
        gameManager = FindObjectOfType<GameManager>();
        originalPos1 = panelDialogo[0].position;
        originalPos2 = panelDialogo[1].position;
        originalPositionPremisa = premisa.position;
        StartCoroutine(Premisa());
    }
    public void ShowDialogue(string dialogo)
    {
        if(panelDirection == PanelDirection.DERECHA)
        {
            panelDialogo[0].DOMove(guiaPanel[0].position, .5f);
            textoDialogo1.text = dialogo;
        }
        if(panelDirection == PanelDirection.IZQUIERDA)
        {
            panelDialogo[1].DOMove(guiaPanel[1].position, .5f);
            textoDialogo2.text = dialogo;
        }
        
    }
    public void ShowDialogueTutorial(string dialogoTutorial)
    {
        textoDialogoPremisa.text = dialogoTutorial;
    }
    public void HideDialogue()
    {
        panelDialogo[0].DOMove(originalPos1, .5f);
        panelDialogo[1].DOMove(originalPos2, .5f);
        
    }

    public void HideDialoguePremisa()
    {
        premisa.DOMove(originalPositionPremisa, .5f);
    }

    IEnumerator Premisa()
    {
        yield return new WaitForSeconds(0.00001f);//kwea si se borra esta linea el juego no funciona
        StartCoroutine(gameManager.VideoPremisa());
        yield return new WaitForSeconds(3.5f);
        ChangeScene.intance.musicaNivel.Play();
        premisa.DOMove(guiaPremisa.position, .5f);
    }
}
