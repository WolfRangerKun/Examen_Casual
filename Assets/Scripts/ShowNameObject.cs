using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowNameObject : MonoBehaviour
{
    public GameObject thisObj;
    public TMP_Text thisNameObj;

    private void Start()
    {
        thisNameObj.text = thisObj.name.ToString();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            thisNameObj.gameObject.SetActive(true);
            thisObj.GetComponent<SpriteRenderer>().color = Color.gray;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            thisNameObj.gameObject.SetActive(false);
            thisObj.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
