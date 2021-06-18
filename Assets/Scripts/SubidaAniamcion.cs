using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SubidaAniamcion : MonoBehaviour
{
    public float pushDireccion = 1f;
    GameObject playerObj;
    Vector3 player;
    Vector3 upPosition;
    Vector3 leftPosition;
    Vector3 rightPosition;
    Vector3 rotation;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(AnimacionSubida(other));
        }
    }

    private void Start()
    {
       
    }
    private void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<PlayerMovement>().targetPosition;
        playerObj = GameObject.FindGameObjectWithTag("Player");
        upPosition = player + new Vector3(0, 1, 0);
        leftPosition = player + new Vector3(-1f, 0, 0);
        rightPosition = player + new Vector3(1f, 0, 0);
        rotation = playerObj.transform.position;
    }

    IEnumerator AnimacionSubida(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            GetComponent<BoxCollider2D>().isTrigger = false;
            Debug.Log("oli");
            other.gameObject.transform.DOMove(rightPosition, .1f);
            other.gameObject.GetComponent<PlayerMovement>().targetPosition += new Vector3(1f, 0, 0);
            yield return new WaitForSeconds(.5f);
            other.gameObject.transform.DORotate((rotation + new Vector3(0, 0, -90)), 1);
            other.gameObject.transform.DOMove(upPosition, 1);
            other.gameObject.GetComponent<PlayerMovement>().targetPosition += new Vector3(0, 1, 0);
            yield return new WaitForSeconds(.5f);
            other.gameObject.transform.DOMove(leftPosition, .5f);
            other.gameObject.transform.DORotate((rotation + new Vector3(0, 0, 0)), 1f);
            other.gameObject.GetComponent<PlayerMovement>().targetPosition += new Vector3(-1f, 0, 0);
            yield return new WaitForSeconds(.1f);
            GetComponent<BoxCollider2D>().isTrigger = false;
            //other.gameObject.transform.DOMove(leftPosition, 1);
            //other.gameObject.GetComponent<PlayerMovement>().targetPosition += new Vector3(1, 0, 0);
            Debug.Log("chao");
        }
    }
}
