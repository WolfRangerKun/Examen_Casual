using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class DialogueSistem : MonoBehaviour
{
    public static DialogueSistem instance;
    public TextMeshProUGUI textoDialogo;
    public RectTransform panelDialogo, guiaPanel;
    private Vector2 originalPos;

    private void Awake()
    {
        instance = this;
        originalPos = panelDialogo.position;
    }

    public void ShowDialogue(string dialogo)
    {
        panelDialogo.DOMove(guiaPanel.position, .5f);
        textoDialogo.text = dialogo;
    }
    public void HideDialogue()
    {
        panelDialogo.DOMove(originalPos, .5f);
    }
}
