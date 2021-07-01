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
    public List<RectTransform> panelDialogo;
    public List<RectTransform> guiaPanel;
    private Vector2 originalPos1, originalPos2;

    private void Awake()
    {
        instance = this;
        originalPos1 = panelDialogo[0].position;
        originalPos2 = panelDialogo[1].position;
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
    public void HideDialogue()
    {
        panelDialogo[0].DOMove(originalPos1, .5f);
        panelDialogo[1].DOMove(originalPos2, .5f);
    }
}
