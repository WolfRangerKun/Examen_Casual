using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEntrySecondFlor : MonoBehaviour
{
    public GameObject Triger;
    private void OnCollisionEnter2D(Collision2D other)
    {
        foreach(ContactPoint2D hitPos in other.contacts)
        {
            if(hitPos.normal.x > 0 && other.gameObject.CompareTag("Player"))
            {
                Triger.SetActive(false);
            }
        }
    }
}
