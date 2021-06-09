using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objeto : MonoBehaviour
{
    public Transform rayCast, rayCast2, rayCast3, rayCast4;
    public float distanceRay = 1;
    public LayerMask obstacles;

    private void Update()
    {
        Debug.DrawRay(rayCast2.position, rayCast.right * distanceRay);
        Debug.DrawRay(rayCast.position, -rayCast.right * distanceRay);
        Debug.DrawRay(rayCast3.position, rayCast.up * distanceRay);
        Debug.DrawRay(rayCast4.position, -rayCast.up * distanceRay);
        RaycastHit2D hit = Physics2D.Raycast(rayCast.position, -rayCast.right, distanceRay);
        RaycastHit2D hit2 = Physics2D.Raycast(rayCast2.position, rayCast.right, distanceRay);
        RaycastHit2D hit3 = Physics2D.Raycast(rayCast3.position, rayCast.up, distanceRay);
        RaycastHit2D hit4 = Physics2D.Raycast(rayCast4.position, -rayCast.up, distanceRay);

        if (hit.collider.IsTouchingLayers(obstacles))
        {
            transform.position = Vector2.zero;
        }

    }

}
