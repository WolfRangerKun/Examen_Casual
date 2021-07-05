using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BridgeTutorial : MonoBehaviour
{
    public float time;
    public SegundoPiso segundoPiso;
    public GameObject limitBridges;
    // Update is called once per frame
    void Update()
    {
        if (segundoPiso.libro[1].activeSelf == true)
        {
            limitBridges.SetActive(false);
        }
        if (segundoPiso.libro[1].activeSelf == false)
        {
            limitBridges.SetActive(true);
        }

    }


    public IEnumerator Tming()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
        yield return new WaitForSeconds(time);
        //gameObject.SetActive(true);
    }
}
