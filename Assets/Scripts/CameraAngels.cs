using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraAngels : MonoBehaviour
{
    public CinemachineVirtualCamera cam;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cam.Priority = 99;
            Debug.Log(" ME CAMBIE");        
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            cam.Priority = 0;
            Debug.Log("AHORA NO FUNCIONO");
        }
    }
}
