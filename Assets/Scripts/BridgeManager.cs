using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeManager : MonoBehaviour
{
    public List<GameObject> bridges;
    public bool active1, active2, active3 ,active4, active5, active6;

    public void Update()
    {
        if(active1) bridges[0].SetActive(true);
        if(active2) bridges[1].SetActive(true);
        if(active3) bridges[2].SetActive(true);
        if(active4) bridges[3].SetActive(true);
        if(active5) bridges[4].SetActive(true);
        if(active6) bridges[5].SetActive(true);
    }
}
