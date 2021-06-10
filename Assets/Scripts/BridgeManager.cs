using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeManager : MonoBehaviour
{
    public int pieceBridges;
    public List<GameObject> bridges;

    public void Update()
    {
        if(pieceBridges == 1) bridges[0].SetActive(true);
        if(pieceBridges == 2) bridges[1].SetActive(true);
        if(pieceBridges == 3) bridges[2].SetActive(true);

    }
}
