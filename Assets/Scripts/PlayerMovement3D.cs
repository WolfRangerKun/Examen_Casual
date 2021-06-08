using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    Animator anim;
    public Vector3 targetPosition;
    public Direction direction;
    public LayerMask obstacles;
    public LayerMask move;
    public float speed = 5;
    public Transform rayCast, rayCast2, rayCast3, rayCast4;
    public float distanceRay;
    public float distanceRayCollision;
    public float distanceMovement = 1f;
    public int pushDistance = 1;
    void Start()
    {
        anim = GetComponent<Animator>();
        targetPosition = transform.position;
        direction = Direction.down;
    }

    void Update()
    {
        Debug.DrawRay(rayCast2.position, Vector3.right * distanceRay);
        Debug.DrawRay(rayCast.position, Vector3.left * distanceRay);
        Debug.DrawRay(rayCast3.position, Vector3.forward * distanceRay);
        Debug.DrawRay(rayCast4.position, Vector3.back * distanceRay);
        RaycastHit hit;
        Physics.Raycast(rayCast.position, Vector3.left, out hit, distanceRay, move);
        RaycastHit hit2;
        Physics.Raycast(rayCast2.position, Vector3.right, out hit2, distanceRay, move);
        RaycastHit hit3;
        Physics.Raycast(rayCast3.position, Vector3.forward, out hit3, distanceRay, move);
        RaycastHit hit4;
        Physics.Raycast(rayCast4.position, Vector3.back, out hit4, distanceRay, move);
        Vector3 axisDirection = new Vector3(Input.GetAxis("Horizontal"), 0f , Input.GetAxis("Vertical"));
        if (axisDirection != Vector3.zero && targetPosition == transform.position)
        {
            if (Mathf.Abs(axisDirection.x) > Mathf.Abs(axisDirection.z))
            {
                if (axisDirection.x > 0)
                {
                    direction = Direction.right;
                    if (hit2.collider && direction == Direction.right)
                    {
                        hit2.transform.position = new Vector3(hit2.transform.position.x + pushDistance, hit2.transform.position.y, hit2.transform.position.z);
                    }
                    if (!CheckCollision)
                        targetPosition += new Vector3(distanceMovement, transform.position.y, 0f);
                }
                else
                {
                    direction = Direction.left;
                    if (hit.collider && direction == Direction.left)
                    {
                        hit.transform.position = new Vector3(hit.transform.position.x - pushDistance, hit.transform.position.y, hit.transform.position.z);
                    }
                    if (!CheckCollision)
                        targetPosition -= new Vector3(distanceMovement, transform.position.y, 0f);
                }
            }
            else
            {
                if (axisDirection.z > 0)
                {
                    direction = Direction.up;
                    if (hit3.collider && direction == Direction.up)
                    {
                        hit3.transform.position = new Vector3(hit3.transform.position.x, hit3.transform.position.y + pushDistance, hit3.transform.position.z);
                    }
                    if (!CheckCollision)
                        targetPosition += new Vector3(0f,transform.position.y, distanceMovement);
                }
                else
                {
                    direction = Direction.down;
                    if (hit4.collider && direction == Direction.down)
                    {
                        hit4.transform.position = new Vector3(hit4.transform.position.x, hit4.transform.position.y - pushDistance, hit4.transform.position.z);
                    }
                    if (!CheckCollision)
                        targetPosition -= new Vector3(0f, transform.position.y, distanceMovement);
                }
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    public bool CheckCollision
    {
        get
        {
            //bool col = true;
            RaycastHit rh;

            Vector3 dir = Vector3.zero;
            if (direction == Direction.down)
                dir = Vector3.back;
            if (direction == Direction.up)
                dir = Vector3.forward;
            if (direction == Direction.left)
                dir = Vector3.left;
            if (direction == Direction.right)
                dir = Vector3.right;

            Physics.Raycast(transform.position, dir, out rh, distanceRayCollision, obstacles);
            Debug.DrawRay(transform.position, dir, Color.red, distanceRayCollision);

            return rh.collider != null;
        }


    }
}
