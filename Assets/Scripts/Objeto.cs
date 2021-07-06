using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public PlayerMovement player;
    public float distanceRayCollision = 1f;
    public LayerMask obstacules;
    public Transform rayCast, rayCast2, rayCast3, rayCast4;
    public float distanceRay = 0.1f;
    public bool inWall, inWall2, inWall3, inWall4;
    public List<GameObject> contacts;

    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    void Update()
    {
        Debug.DrawRay(rayCast2.position, rayCast.right * distanceRay);
        Debug.DrawRay(rayCast.position, -rayCast.right * distanceRay);
        Debug.DrawRay(rayCast3.position, rayCast.up * distanceRay);
        Debug.DrawRay(rayCast4.position, -rayCast.up * distanceRay);
        RaycastHit2D hit = Physics2D.Raycast(rayCast.position, -rayCast.right, distanceRay, obstacules);
        RaycastHit2D hit2 = Physics2D.Raycast(rayCast2.position, rayCast.right, distanceRay, obstacules);
        RaycastHit2D hit3 = Physics2D.Raycast(rayCast3.position, rayCast.up, distanceRay, obstacules);
        RaycastHit2D hit4 = Physics2D.Raycast(rayCast4.position, -rayCast.up, distanceRay, obstacules);

        if (hit.collider)
        {
            if (gameObject.tag == "Atomo")
            {
                if (hit.collider.tag == "Vaso")
                {

                }
                else
                {
                    inWall = true;// izquierda
                    contacts[0].SetActive(true); // contrario
                }
            }
            else
            {
                inWall = true;// izquierda
                contacts[0].SetActive(true); // contrario
            }
            
        }
        else
        {
            inWall = false;
            contacts[0].SetActive(false);
            if(!GameManager.instance.finishlvl)
               player.canMove = true;
        }
        if (hit2.collider)
        {
            if (gameObject.tag == "Atomo")
            {
                if (hit2.collider.tag == "Vaso")
                {

                }
                else
                {
                    inWall2 = true; // derecha 
                    contacts[1].SetActive(true); // contrario
                }
            }
            else
            {
                inWall2 = true; // derecha 
                contacts[1].SetActive(true); // contrario
            }
            
        }
        else
        {
            inWall2 = false;
            contacts[1].SetActive(false);
            if (!GameManager.instance.finishlvl)
                player.canMove = true;
        }
        if (hit3.collider)
        {
            if (gameObject.tag == "Atomo")
            {
                if (hit3.collider.tag == "Vaso")
                {

                }
                else
                {
                    inWall3 = true;// arriba 
                    contacts[2].SetActive(true); // contrario
                }

            }
            else
            {
                inWall3 = true;// arriba 
                contacts[2].SetActive(true); // contrario
            }
            
        }
        else
        {
            inWall3 = false;
            contacts[2].SetActive(false);
            if (!GameManager.instance.finishlvl)
                player.canMove = true;
        }
        if (hit4.collider)
        {
            if (gameObject.tag == "Atomo")
            {
                if (hit4.collider.tag == "Vaso")
                {

                }
                else
                {
                    inWall4 = true;// abajo
                    contacts[3].SetActive(true); // contrario
                }
            }
            else
            {
                inWall4 = true;// abajo
                contacts[3].SetActive(true); // contrario
         
            }
            
        }
        else
        {
            inWall4 = false;
            contacts[3].SetActive(false);
            if (!GameManager.instance.finishlvl)
                player.canMove = true;
        }
    }
}
