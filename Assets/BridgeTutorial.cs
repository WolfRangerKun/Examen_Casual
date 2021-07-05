using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BridgeTutorial : MonoBehaviour
{
    public float time;
    public SegundoPiso segundoPiso;
    public GameObject limitBridges;
    public bool dspsDeSubir;
    public IEnumerator Tming()
    {
        yield return new WaitForSeconds(0.5f);
        limitBridges.SetActive(false);
        yield return new WaitForSeconds(time);
        dspsDeSubir = true;
    }

    private void Update()
    {
        if (dspsDeSubir)
        {
            OffOrOn();
        }
        
    }
    public void OffOrOn()
    {
        if (segundoPiso.libro[1].activeSelf == true)
        {
            limitBridges.SetActive(false);
        }
        if (segundoPiso.libro[1].activeSelf == false)
        {
            limitBridges.SetActive(true);
            dspsDeSubir = false;
        }
    }
}
