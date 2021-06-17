using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    public bool sinPuente = true;
    public List<GameObject> limits;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && sinPuente)
        {
            limits[0].SetActive(false);
            limits[1].SetActive(false);
            limits[2].SetActive(false);
            limits[3].SetActive(false);
        }
        else
        {
            limits[0].SetActive(true);
            limits[1].SetActive(true);
            limits[2].SetActive(true);
            limits[3].SetActive(true);
        }
    }
}
