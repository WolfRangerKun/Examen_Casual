using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    up,
    down,
    left,
    right
}
public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement instace;
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
    public bool canMove = true;
    public int life = 2;
    public AudioSource playerWalk, hitSounds;
    public List<AudioClip> objectSounds;
    //0 playerWalk
    //1 vidrio
    //2 hitPared;
    private void Awake()
    {
        instace = this;
    }
    void Start()
    {
        anim = GetComponent<Animator>();
        targetPosition = transform.position;
        direction = Direction.down;
    }
    bool playSound;
    void Update()
    {

        if (canMove)
        {
            Debug.DrawRay(rayCast2.position, rayCast.right * distanceRay);
            Debug.DrawRay(rayCast.position, -rayCast.right * distanceRay);
            Debug.DrawRay(rayCast3.position, rayCast.up * distanceRay);
            Debug.DrawRay(rayCast4.position, -rayCast.up * distanceRay);
            RaycastHit2D hit = Physics2D.Raycast(rayCast.position, -rayCast.right, distanceRay, move);
            RaycastHit2D hit2 = Physics2D.Raycast(rayCast2.position, rayCast.right, distanceRay, move);
            RaycastHit2D hit3 = Physics2D.Raycast(rayCast3.position, rayCast.up, distanceRay, move);
            RaycastHit2D hit4 = Physics2D.Raycast(rayCast4.position, -rayCast.up, distanceRay, move);
            Vector2 axisDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            anim.SetInteger("Direction", (int)direction);
            if (axisDirection == Vector2.zero && targetPosition == transform.position)
            {
                playSound = true;
            }
            if (axisDirection != Vector2.zero && targetPosition == transform.position)
            {
                if (Mathf.Abs(axisDirection.x) > Mathf.Abs(axisDirection.y))
                {
                    if (axisDirection.x > 0)
                    {
                        direction = Direction.right;
                        if (hit2.collider && direction == Direction.right)
                        {
                            if (hit2.collider.gameObject.GetComponent<Objeto>() && hit2.collider.gameObject.GetComponent<Objeto>().inWall2 == false)
                                hit2.transform.position = new Vector2(hit2.transform.position.x + pushDistance, hit2.transform.position.y);


                            if (hit2.collider.gameObject.GetComponent<Atomo>() && hit2.collider.gameObject.GetComponent<Objeto>().inWall2 == false)
                            {
                                hit2.collider.gameObject.GetComponent<Atomo>().StartCoroutine(hit2.collider.gameObject.GetComponent<Atomo>().CambiarSpriteMovimiento());
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit2.collider.gameObject.GetComponent<Vaso>() && hit2.collider.gameObject.GetComponent<Vaso>().cantidadAgua >= 15 && hit2.collider.gameObject.GetComponent<Objeto>().inWall2 == false)
                            {
                                hit2.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit2.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(1));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            else
                                if (hit2.collider.gameObject.GetComponent<Vaso>() && hit2.collider.gameObject.GetComponent<Objeto>().inWall2 == false)
                            {
                                hit2.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit2.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit2.collider.gameObject.GetComponent<OnCollisionChangeSprite>() && hit2.collider.gameObject.GetComponent<Objeto>().inWall2 == false)
                            {
                                hit2.collider.gameObject.GetComponent<OnCollisionChangeSprite>().StartCoroutine(hit2.collider.gameObject.GetComponent<OnCollisionChangeSprite>().CambiarSpriteVaso(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                        }
                        if (!CheckCollision)
                        {
                            targetPosition += new Vector3(distanceMovement, 0f, 0f);
                            if (direction == Direction.right)
                            {
                                if (hit2.collider)
                                {

                                }
                                else
                                {
                                    playerWalk.clip = objectSounds[0];
                                    playerWalk.Play();
                                }
                            }
                        }
                        else if (CheckCollision)
                        {
                            if (playSound)
                            {
                                hitSounds.clip = objectSounds[2];
                                hitSounds.Play();
                                playSound = false;
                            }
                        }
                    }
                    else
                    {
                        direction = Direction.left;
                        if (hit.collider && direction == Direction.left)
                        {
                            if (hit.collider.gameObject.GetComponent<Objeto>() && hit.collider.gameObject.GetComponent<Objeto>().inWall == false)
                                hit.transform.position = new Vector2(hit.transform.position.x - pushDistance, hit.transform.position.y);

                            if (hit.collider.gameObject.GetComponent<Atomo>() && hit.collider.gameObject.GetComponent<Objeto>().inWall == false)
                            {
                                hit.collider.gameObject.GetComponent<Atomo>().StartCoroutine(hit.collider.gameObject.GetComponent<Atomo>().CambiarSpriteMovimiento());
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit.collider.gameObject.GetComponent<Vaso>() && hit.collider.gameObject.GetComponent<Vaso>().cantidadAgua >= 15 && hit.collider.gameObject.GetComponent<Objeto>().inWall == false)
                            {
                                hit.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(1));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            else
                                if (hit.collider.gameObject.GetComponent<Vaso>() && hit.collider.gameObject.GetComponent<Objeto>().inWall == false)
                            {
                                hit.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit.collider.gameObject.GetComponent<OnCollisionChangeSprite>() && hit.collider.gameObject.GetComponent<Objeto>().inWall == false)
                            {
                                hit.collider.gameObject.GetComponent<OnCollisionChangeSprite>().StartCoroutine(hit.collider.gameObject.GetComponent<OnCollisionChangeSprite>().CambiarSpriteVaso(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                        }
                        if (!CheckCollision)
                        {
                            targetPosition -= new Vector3(distanceMovement, 0f, 0f);
                            if (direction == Direction.left)
                            {
                                if (hit.collider)
                                {

                                }
                                else
                                {
                                    playerWalk.clip = objectSounds[0];
                                    playerWalk.Play();
                                }
                            }
                        }
                        else if (CheckCollision)
                        {
                            if (playSound)
                            {
                                hitSounds.clip = objectSounds[2];
                                hitSounds.Play();
                                playSound = false;
                            }
                        }
                    }
                }
                else
                {
                    if (axisDirection.y > 0)
                    {
                        direction = Direction.up;
                        if (hit3.collider && direction == Direction.up)
                        {
                            if (hit3.collider.gameObject.GetComponent<Objeto>() && hit3.collider.gameObject.GetComponent<Objeto>().inWall3 == false)
                                hit3.transform.position = new Vector2(hit3.transform.position.x, hit3.transform.position.y + pushDistance);

                            if (hit3.collider.gameObject.GetComponent<Atomo>() && hit3.collider.gameObject.GetComponent<Objeto>().inWall3 == false)
                            {
                                hit3.collider.gameObject.GetComponent<Atomo>().StartCoroutine(hit3.collider.gameObject.GetComponent<Atomo>().CambiarSpriteMovimiento());
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit3.collider.gameObject.GetComponent<Vaso>() && hit3.collider.gameObject.GetComponent<Vaso>().cantidadAgua >= 15 && hit3.collider.gameObject.GetComponent<Objeto>().inWall3 == false)
                            {
                                hit3.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit3.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(1));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            else
                                if (hit3.collider.gameObject.GetComponent<Vaso>() && hit3.collider.gameObject.GetComponent<Objeto>().inWall3 == false)
                            {
                                hit3.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit3.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit3.collider.gameObject.GetComponent<OnCollisionChangeSprite>() && hit3.collider.gameObject.GetComponent<Objeto>().inWall3 == false)
                            {
                                hit3.collider.gameObject.GetComponent<OnCollisionChangeSprite>().StartCoroutine(hit3.collider.gameObject.GetComponent<OnCollisionChangeSprite>().CambiarSpriteVaso(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                        }
                        if (!CheckCollision)
                        {
                            targetPosition += new Vector3(0f, distanceMovement, 0f);
                            if (direction == Direction.up)
                            {
                                if (hit3.collider)
                                {

                                }
                                else
                                {
                                    playerWalk.clip = objectSounds[0];
                                    playerWalk.Play();
                                }
                            }
                        }
                        else if (CheckCollision)
                        {
                            if (playSound)
                            {
                                hitSounds.clip = objectSounds[2];
                                hitSounds.Play();
                                playSound = false;
                            }
                        }
                    }
                    else
                    {
                        direction = Direction.down;
                        if (hit4.collider && direction == Direction.down)
                        {
                            if (hit4.collider.gameObject.GetComponent<Objeto>() && hit4.collider.gameObject.GetComponent<Objeto>().inWall4 == false)
                                hit4.transform.position = new Vector2(hit4.transform.position.x, hit4.transform.position.y - pushDistance);

                            if (hit4.collider.gameObject.GetComponent<Atomo>() && hit4.collider.gameObject.GetComponent<Objeto>().inWall4 == false)
                            {
                                hit4.collider.gameObject.GetComponent<Atomo>().StartCoroutine(hit4.collider.gameObject.GetComponent<Atomo>().CambiarSpriteMovimiento());
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit4.collider.gameObject.GetComponent<Vaso>() && hit4.collider.gameObject.GetComponent<Vaso>().cantidadAgua >= 15 && hit4.collider.gameObject.GetComponent<Objeto>().inWall4 == false)
                            {
                                hit4.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit4.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(1));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            else
                                if (hit4.collider.gameObject.GetComponent<Vaso>() && hit4.collider.gameObject.GetComponent<Objeto>().inWall4 == false)
                            {
                                hit4.collider.gameObject.GetComponent<Vaso>().StartCoroutine(hit4.collider.gameObject.GetComponent<Vaso>().CambiarSpriteMovimiento(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                            if (hit4.collider.gameObject.GetComponent<OnCollisionChangeSprite>() && hit4.collider.gameObject.GetComponent<Objeto>().inWall4 == false)
                            {
                                hit4.collider.gameObject.GetComponent<OnCollisionChangeSprite>().StartCoroutine(hit4.collider.gameObject.GetComponent<OnCollisionChangeSprite>().CambiarSpriteVaso(0));
                                hitSounds.clip = objectSounds[1];
                                hitSounds.Play();
                            }
                        }
                        if (!CheckCollision)
                        {
                            targetPosition -= new Vector3(0f, distanceMovement, 0f);
                            if (direction == Direction.down)
                            {
                                if (hit4.collider)
                                {

                                }
                                else
                                {
                                    playerWalk.clip = objectSounds[0];
                                    playerWalk.Play();
                                }
                            }
                        }
                        else if (CheckCollision)
                        {
                            if (playSound)
                            {
                                hitSounds.clip = objectSounds[2];
                                hitSounds.Play();
                                playSound = false;
                            }
                        }
                    }
                }
            }
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            //
        }

    }

    public bool CheckCollision
    {
        get
        {
            RaycastHit2D rh;

            Vector2 dir = Vector2.zero;
            if (direction == Direction.down)
                dir = Vector2.down;
            if (direction == Direction.up)
                dir = Vector2.up;
            if (direction == Direction.left)
                dir = Vector2.left;
            if (direction == Direction.right)
                dir = Vector2.right;

            rh = Physics2D.Raycast(transform.position, dir, distanceRayCollision, obstacles);
            Debug.DrawRay(transform.position, dir, Color.red, distanceRayCollision);

            return rh.collider != null;
        }


    }
}
