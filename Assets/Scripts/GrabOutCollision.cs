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
    bool colUp, colDown, colLeft, colRight;
    bool canGrab;
    public AudioSource dragSound;
    private void Awake()
    {
        dragSound = GetComponent<AudioSource>();
        player = FindObjectOfType<PlayerMovement>();
        thisObject = transform.parent.parent.parent.gameObject;
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            grabText.gameObject.SetActive(true);
            if (collisionUp)
                colUp = true;
            if (collisionDown)
                colDown = true;
            if (collisionLeft)
                colLeft = true;
            if (collisionRight)
                colRight = true;
        }
        else
            return;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            grabText.gameObject.SetActive(false);
            colRight = false;
            colUp = false;
            colLeft = false;
            colDown = false;
        }
        else
            return;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collisionUp && colUp)
        {
            StartCoroutine(ColUp());
        }
        
        if (Input.GetKeyDown(KeyCode.E) && collisionDown && colDown)
        {
            StartCoroutine(ColDown());
        }
        
        if (Input.GetKeyDown(KeyCode.E) && collisionLeft && colLeft)
        {
            StartCoroutine(ColLeft());
        }
        
        if (Input.GetKeyDown(KeyCode.E) && collisionRight && colRight)
        {
            StartCoroutine(ColRight());
        }
    }

    IEnumerator ColUp()
    {
        dragSound.Play();
        player.canMove = false;
        player.transform.position += new Vector3(0f, player.distanceMovement, 0f);
        player.targetPosition += new Vector3(0f, player.distanceMovement, 0f);
        thisObject.transform.position += new Vector3(0f, player.distanceMovement, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColDown()
    {
        dragSound.Play();
        player.canMove = false;
        player.transform.position -= new Vector3(0f, player.distanceMovement, 0f);
        player.targetPosition -= new Vector3(0f, player.distanceMovement, 0f);
        thisObject.transform.position -= new Vector3(0f, player.distanceMovement, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColLeft()
    {
        dragSound.Play();
        player.canMove = false;
        player.transform.position -= new Vector3(player.distanceMovement, 0f, 0f);
        player.targetPosition -= new Vector3(player.distanceMovement, 0f, 0f);
        thisObject.transform.position -= new Vector3(player.distanceMovement, 0f, 0f);
        yield return new WaitForSeconds(.2f);
    }

    IEnumerator ColRight()
    {
        dragSound.Play();
        player.canMove = false;
        player.transform.position += new Vector3(player.distanceMovement, 0f, 0f);
        player.targetPosition += new Vector3(player.distanceMovement, 0f, 0f);
        thisObject.transform.position += new Vector3(player.distanceMovement, 0f, 0f);
        yield return new WaitForSeconds(.2f);
    }

}
