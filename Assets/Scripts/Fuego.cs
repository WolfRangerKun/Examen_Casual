using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public PlayerMovement player;
    public float pushDireccion = 1f;
    private void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
    }
    public enum DIRECCION
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }
    public DIRECCION direccionCaida;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            EmpujarDano(direccionCaida);
            StartCoroutine(DanoVisual(other));
        }
    }
    void EmpujarDano(DIRECCION direccioncaida)
    {
        direccioncaida = direccionCaida;
        switch (direccioncaida)
        {
            case DIRECCION.UP:
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + pushDireccion);
                player.targetPosition.y += pushDireccion;
                break;
            case DIRECCION.DOWN:
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - pushDireccion);
                player.targetPosition.y -= pushDireccion;
                break;
            case DIRECCION.RIGHT:
                player.transform.position = new Vector2(player.transform.position.x + pushDireccion, player.transform.position.y);
                player.targetPosition.x += pushDireccion;
                break;
            case DIRECCION.LEFT:
                player.transform.position = new Vector2(player.transform.position.x - pushDireccion, player.transform.position.y);
                player.targetPosition.x -= pushDireccion;
                break;
        }
    }

    IEnumerator DanoVisual(Collider2D other)
    {
        PlayerMovement.instace.canMove = false;
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(.1f);
        other.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        PlayerMovement.instace.canMove = true;
    }
    //public void MovementFall(Collider2D other, DIRECCION dire)
    //{
    //    dire = direccionCaida;
    //    switch (dire)
    //    {
    //        case DIRECCION.UP:
    //            other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y + pushDireccion);
    //            player.targetPosition.y += pushDireccion;
    //            break;
    //        case DIRECCION.DOWN:
    //            other.transform.position = new Vector2(other.transform.position.x, other.transform.position.y - pushDireccion);
    //            player.targetPosition.y -= pushDireccion;
    //            break;
    //        case DIRECCION.RIGHT:
    //            other.transform.position = new Vector2(other.transform.position.x + pushDireccion, other.transform.position.y);
    //            player.targetPosition.x += pushDireccion;
    //            break;
    //        case DIRECCION.LEFT:
    //            other.transform.position = new Vector2(other.transform.position.x - pushDireccion, other.transform.position.y);
    //            player.targetPosition.x -= pushDireccion;
    //            break;
    //    }
    //}
}
