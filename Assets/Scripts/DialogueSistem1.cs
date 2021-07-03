using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class DialogueSistem1 : MonoBehaviour
{
    public static DialogueSistem1 instance;
    public TextMeshProUGUI textoDialogoPremisa;
    public RectTransform premisa, guiaPremisa;
    private Vector2 originalPositionPremisa;
    public static bool finishPremise;
    private void Awake()
    {
        instance = this;
        originalPositionPremisa = premisa.position;
        StartCoroutine(Premisa());
    }
    public void ShowDialogueTutorial(string dialogoTutorial)
    {
        textoDialogoPremisa.text = dialogoTutorial;
    }
    public void HideDialogue()
    {
        premisa.DOMove(originalPositionPremisa, .5f);
    }

    IEnumerator Premisa()
    {
        yield return new WaitForSeconds(0.5f);
        premisa.DOMove(guiaPremisa.position, .5f);
    }
}
