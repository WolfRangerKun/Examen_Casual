using DG.Tweening;
using System.Collections;
using UnityEngine;

public class SubidaAniamcion : MonoBehaviour
{
    public GameObject goUpText;
    public float pushDireccion = 1f;
    PlayerMovement player;
    GameObject playerObj;
    Animator anim;
    public BridgeTutorial limit;
    Vector3 upPosition;
    Vector3 leftPosition;
    Vector3 rightPosition;
    Vector3 rotation;
    bool canGoUp;
    public bool isSubidaIzq, isSubidaDer;
    private void Awake()
    {
        player = FindObjectOfType<PlayerMovement>();
        playerObj = GameObject.FindGameObjectWithTag("Player");
        anim = player.GetComponent<Animator>();
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canGoUp = true;
            goUpText.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canGoUp = false;
            goUpText.SetActive(false);
        }
    }
    private void Start()
    {
        
        rotation = playerObj.transform.position;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && canGoUp)
        {
            StartCoroutine(AnimacionSubida());
            StartCoroutine(limit.Tming());
            canGoUp = false;
            goUpText.SetActive(false);
            
        }
        else
        {
            anim.SetBool("Salto", false);
        }
    }

    IEnumerator AnimacionSubida()
    {
        if (isSubidaDer)
        {
            anim.SetBool("Salto", true);
            player.canMove = false;
            GetComponent<BoxCollider2D>().isTrigger = false;
            Debug.Log("paarriba");

            //player.gameObject.transform.DORotate((playerObj.transform.position + new Vector3(0, 0, -90)), 1);
            player.gameObject.transform.DOMove(player.targetPosition + new Vector3(0, 1, 0), 1);
            yield return new WaitForSeconds(1f);
            player.targetPosition += new Vector3(0, player.distanceMovement, 0);

            Debug.Log("PaIzq");
            //player.gameObject.transform.DORotate((playerObj.transform.position + new Vector3(0, 0, 0)), 1f);
            player.gameObject.transform.DOMove(player.targetPosition - new Vector3(1, 0, 0), 1f);
            yield return new WaitForSeconds(1f);
            player.targetPosition -= new Vector3(player.distanceMovement, 0, 0);
            GetComponent<BoxCollider2D>().isTrigger = true;
            player.canMove = true;
            Debug.Log("chao");

        }

        if (isSubidaIzq)
        {
            anim.transform.Rotate(0, 180, 0);
            //player.GetComponent<SpriteRenderer>().flipX = false;
            anim.SetBool("Salto", true);
            
            player.canMove = false;
            GetComponent<BoxCollider2D>().isTrigger = false;
            Debug.Log("paarriba");

            //player.gameObject.transform.DORotate((playerObj.transform.position + new Vector3(0, 0, 90)), 1);
            player.gameObject.transform.DOMove(player.targetPosition + new Vector3(0, 1, 0), 1);
            yield return new WaitForSeconds(1f);
            player.targetPosition += new Vector3(0, player.distanceMovement, 0);

            Debug.Log("PaIzq");
            anim.transform.Rotate(0, 180, 0);
            //player.gameObject.transform.DORotate((playerObj.transform.position + new Vector3(0, 0, 0)), 1f);
            player.gameObject.transform.DOMove(player.targetPosition + new Vector3(1, 0, 0), 1f);
            yield return new WaitForSeconds(1f);
            player.targetPosition += new Vector3(player.distanceMovement, 0, 0);
            GetComponent<BoxCollider2D>().isTrigger = true;
            player.canMove = true;
            Debug.Log("chao");
        }
    }
}
