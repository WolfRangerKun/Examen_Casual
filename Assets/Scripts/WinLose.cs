using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinLose : MonoBehaviour
{
    bool canWinLose;
    public TMP_Text goIntoVasoText;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canWinLose = true;
            goIntoVasoText.gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canWinLose = false;
            goIntoVasoText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canWinLose)
        {
            if (Vaso.intance.winChoose)
            {
                StartCoroutine(GameManager.instance.WinningChoose());
                canWinLose = false;
            }
            else if (Vaso.intance.loseChoose)
            {
                StartCoroutine(GameManager.instance.LoseChoose());
                canWinLose = false;
            }
        }
    }
}
