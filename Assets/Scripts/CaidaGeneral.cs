using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaGeneral : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject playerBox;
    public enum DIRECCION
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    public DIRECCION direccionCaida;
    private void Start()
    {
        playerBox = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        MovementFall(other);
        if (other.CompareTag("Player"))
        {
            playerBox.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Salir());
        }
    }
    public void MovementFall(Collider2D other)
    {
        switch (direccionCaida)
        {
            case DIRECCION.UP:
                other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y + 1);
                player.targetPosition.y += 1f;
                break;
            case DIRECCION.DOWN:
                other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y - 1);
                player.targetPosition.y -= 1f;
                break;
            case DIRECCION.RIGHT:
                other.transform.position = new Vector2(other.transform.position.x + 1, other.transform.position.y);
                player.targetPosition.x += 1f;
                break;
            case DIRECCION.LEFT:
                other.transform.position = new Vector2(other.transform.position.x - 1, other.transform.position.y);
                player.targetPosition.x -= 1f;
                break;
        }
    }

    IEnumerator Salir()
    {
        yield return new WaitForSeconds(1f);
        player.enabled = true;
        playerBox.GetComponent<BoxCollider2D>().enabled = true;
    }
}
