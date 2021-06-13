using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEntrySecondFlor : MonoBehaviour
{
    public static CollisionEntrySecondFlor intanse;
    public GameObject triggerAbajo;
    public GameObject triggerArriba;

    private void Awake()
    {
        intanse = this;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        foreach(ContactPoint2D hitPos in other.contacts)
        {
            if(hitPos.normal.x < 0 && other.gameObject.CompareTag("Player"))
            {
                triggerAbajo.SetActive(false);
                triggerArriba.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            triggerAbajo.SetActive(false);
            triggerArriba.SetActive(true);
        }
    }
}
