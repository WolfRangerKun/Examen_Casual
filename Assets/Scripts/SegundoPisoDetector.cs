using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegundoPisoDetector : MonoBehaviour
{
    public Transform rayCast, rayCast2, rayCast3, rayCast4;
    public float distanceRay;
    public LayerMask move;
    public PlayerMovement player;

    private void Start()
    {

    }
    void Update()
    {
        Debug.DrawRay(rayCast2.position, rayCast.right * distanceRay);
        Debug.DrawRay(rayCast.position, -rayCast.right * distanceRay);
        Debug.DrawRay(rayCast3.position, rayCast.up * distanceRay);
        Debug.DrawRay(rayCast4.position, -rayCast.up * distanceRay);
        RaycastHit2D hit = Physics2D.Raycast(rayCast.position, -rayCast.right, distanceRay, move);
        RaycastHit2D hit2 = Physics2D.Raycast(rayCast2.position, rayCast.right, distanceRay, move);
        RaycastHit2D hit3 = Physics2D.Raycast(rayCast3.position, rayCast.up, distanceRay, move);
        RaycastHit2D hit4 = Physics2D.Raycast(rayCast4.position, -rayCast.up, distanceRay, move);

        if (hit.collider && player.direction == Direction.right)
        {

        }
    }

}
