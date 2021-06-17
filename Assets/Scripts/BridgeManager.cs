using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeManager : MonoBehaviour
{
    public List<GameObject> bridges;
    public List<GameObject> limits;
    public bool active1, active2, active3 ,active4, active5, active6;
    public bool sinPuente = true;

    public void Update()
    {
        if (!sinPuente)
        {
            if (active1) bridges[0].SetActive(true);
            if (active2) bridges[1].SetActive(true);
            if (active3) bridges[2].SetActive(true);
            if (active4) bridges[3].SetActive(true);
            if (active5) bridges[4].SetActive(true);
            if (active6) bridges[5].SetActive(true);
        }

    }

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
