using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BridgeTutorial : MonoBehaviour
{
    public static BridgeTutorial bridgeTutorial;
    public float time;
    public SegundoPiso segundoPiso;
    public List<GameObject> limitBridges;
    public bool dspsDeSubir , lvl2;
    private void Awake()
    {
        bridgeTutorial = this;
    }
    public IEnumerator Tming()
    {
        yield return new WaitForSeconds(0.5f);
        limitBridges[0].SetActive(false);
        if(lvl2)
        limitBridges[1].SetActive(false);
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
            limitBridges[0].SetActive(false);
            if(lvl2)
            limitBridges[1].SetActive(false);
        }
        if (segundoPiso.libro[1].activeSelf == false)
        {
            limitBridges[0].SetActive(true);
            if(lvl2)
            limitBridges[1].SetActive(true);
            dspsDeSubir = false;
        }
    }
}
