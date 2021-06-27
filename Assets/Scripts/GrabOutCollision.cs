using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrabOutCollision : MonoBehaviour
{
    public PlayerMovement player;
    public TMP_Text grabText;
    public bool collisionUp, collisionDown, collisionLeft, collisionRight;
    public GameObject thisObject;
    bool canGrab;
    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>();
        thisObject = transform.parent.parent.parent.gameObject;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            grabText.gameObject.SetActive(true);
        }
        else
            return;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            grabText.gameObject.SetActive(false);
        }
        else
            return;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collisionUp)
        {
            StartCoroutine(ColUp());
        }

        if (Input.GetKeyDown(KeyCode.E) && collisionDown)
        {
            StartCoroutine(ColDown());
        }

        if (Input.GetKeyDown(KeyCode.E) && collisionLeft)
        {
            StartCoroutine(ColLeft());
        }

        if (Input.GetKeyDown(KeyCode.E) && collisionRight)
        {
            StartCoroutine(ColRight());
        }
    }

    IEnumerator ColUp()
    {
        player.canMove = false;
        player.transform.position += new Vector3(0f, player.distanceMovement, 0f);
        player.targetPosition += new Vector3(0f, player.distanceMovement, 0f);
        thisObject.transform.position += new Vector3(0f, player.distanceMovement, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColDown()
    {
        player.canMove = false;
        player.transform.position -= new Vector3(0f, player.distanceMovement, 0f);
        player.targetPosition -= new Vector3(0f, player.distanceMovement, 0f);
        thisObject.transform.position -= new Vector3(0f, player.distanceMovement, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColLeft()
    {
        player.canMove = false;
        player.transform.position -= new Vector3(player.distanceMovement, 0f, 0f);
        player.targetPosition -= new Vector3(player.distanceMovement, 0f, 0f);
        thisObject.transform.position -= new Vector3(player.distanceMovement, 0f, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColRight()
    {
        player.canMove = false;
        player.transform.position += new Vector3(player.distanceMovement, 0f, 0f);
        player.targetPosition += new Vector3(player.distanceMovement, 0f, 0f);
        thisObject.transform.position += new Vector3(player.distanceMovement, 0f, 0f);
        yield return new WaitForSeconds(.2f);
    }

}
