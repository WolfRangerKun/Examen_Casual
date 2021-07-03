using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    public PlayerMovement player;
    public float pushDireccion = 1f;
    public bool isFuego;
    private void Awake()
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
            if (!isFuego)
            {
                Empujar(direccionCaida);
            }
            else
            {
                EmpujarDano(direccionCaida);
                StartCoroutine(DanoVisual(other));
            }
        }
        else
            return;
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

    void Empujar(DIRECCION direccioncaida)
    {
        direccioncaida = direccionCaida;
        var zero = player.transform.position += Vector3.zero;
        switch (direccioncaida)
        {
            case DIRECCION.UP:
                StartCoroutine(ChoqueUp());
                break;
            case DIRECCION.DOWN:
                StartCoroutine(ChoqueDown());
                break;
            case DIRECCION.RIGHT:
                StartCoroutine(ChoqueRight());
                break;
            case DIRECCION.LEFT:
                StartCoroutine(ChoqueLeft());
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

    IEnumerator ChoqueUp()
    {
        player.hitSounds.clip = player.objectSounds[2];
        player.hitSounds.Play();
        player.distanceMovement = 0;
        player.targetPosition.y += pushDireccion;
        yield return new WaitForSeconds(.2f);
        player.distanceMovement = 1;
    }

    IEnumerator ChoqueDown()
    {
        player.hitSounds.clip = player.objectSounds[2];
        player.hitSounds.Play();
        player.distanceMovement = 0;
        player.targetPosition.y -= pushDireccion;
        yield return new WaitForSeconds(.2f);
        player.distanceMovement = 1;
    }

    IEnumerator ChoqueLeft()
    {
        player.hitSounds.clip = player.objectSounds[2];
        player.hitSounds.Play();
        player.distanceMovement = 0;
        player.targetPosition.x -= pushDireccion;
        yield return new WaitForSeconds(.2f);
        player.distanceMovement = 1;
    }

    IEnumerator ChoqueRight()
    {
        player.hitSounds.clip = player.objectSounds[2];
        player.hitSounds.Play();
        player.distanceMovement = 0;
        player.targetPosition.x += pushDireccion;
        yield return new WaitForSeconds(.2f);
        player.distanceMovement = 1;
    }
}
