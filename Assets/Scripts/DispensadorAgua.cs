using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispensadorAgua : MonoBehaviour
{
    public GameObject agua, spawnAgua;
    public bool aguaGO;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //StartCoroutine(DispensarAgua());
            ActiveAgua();
        }
    }
    void ActiveAgua()
    {
        aguaGO = !aguaGO;

        if (aguaGO)
        {
            StartCoroutine(DispensarAgua());
        }
        
        return;
    }
    //private void OnTriggerExit2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        //StopCoroutine(DispensarAgua());
    //    }
    //}

    IEnumerator DispensarAgua()
    {
        while (aguaGO)
        {
            Instantiate(agua, spawnAgua.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }
    private void Awa()
    {
        Instantiate(agua, spawnAgua.transform.position, Quaternion.identity);
    }
}
