using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaGeneral : MonoBehaviour
{
    public PlayerMovement player;
    public GameObject playerBox;
    public SegundoPiso segundoPiso;
    public float pushDireccion = 1f;
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
        if (segundoPiso.stayPiso2)
        {
            MovementFall(other);
        }
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
                other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y + pushDireccion);
                player.targetPosition.y += pushDireccion;
                break;
            case DIRECCION.DOWN:
                other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y - pushDireccion);
                player.targetPosition.y -= pushDireccion;
                break;
            case DIRECCION.RIGHT:
                other.transform.position = new Vector2(other.transform.position.x + pushDireccion, other.transform.position.y);
                player.targetPosition.x += pushDireccion;
                break;
            case DIRECCION.LEFT:
                other.transform.position = new Vector2(other.transform.position.x - pushDireccion, other.transform.position.y);
                player.targetPosition.x -= pushDireccion;
                break;
        }
    }

    IEnumerator Salir()
    {
        yield return new WaitForSeconds(0.5f);
        player.enabled = true;
        playerBox.GetComponent<BoxCollider2D>().enabled = true;
    }
}
