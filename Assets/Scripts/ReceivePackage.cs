using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceivePackage : MonoBehaviour
{
    public bool receive, talk, doorMiddle, doorLeft, doorRight, boss;
    public float timeToWait;
    Animator animator;
    //public Packcage.TYPES_PACKAGE packcageNpc;
    public float timeToBreakDance;
    public List<string> dialogues;
    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
        if (receive)
        {
            StartCoroutine(feliz());
        }
    }

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (talk)
    //        {
    //            StopCoroutine(Talk());
    //            if (!receive)
    //            {
    //                DialogueSistem.instance.ShowDialogue(dialogues[2]);
    //                //BagPack mochila = other.GetComponent<BagPack>();
    //                foreach /*(GameObject a in mochila.mochila)*/
    //                {
    //                    if (/*a.GetComponent<Packcage>().typesOfPackage == packcageNpc)*/
    //                    {
    //                        DialogueSistem.instance.ShowDialogue(dialogues[3]);
    //                        mochila.mochila.Remove(a);
    //                        Destroy(a);
    //                        receive = true;
    //                        if (doorMiddle)
    //                        {
    //                            //GameManager.packageReadyCentral++;
    //                        }
    //                        else
    //                        {
    //                            GameManager.tutorial = true;
    //                        }
    //                        if (doorLeft)
    //                        {
    //                            GameManager.left = true;
    //                        }
    //                        if (doorRight)
    //                        {
    //                            GameManager.right = true;
    //                        }
    //                        return;
    //                    }
                        
    //                }
    //            }
    //            else
    //            {
    //                DialogueSistem.instance.ShowDialogue(dialogues[4]);
    //            }
    //        }
    //        else
    //        {
    //            StartCoroutine(Talk());
    //        }
            
    //    }
    //}

    IEnumerator feliz()
    {
        animator.SetBool("BreakDance1", true);
        yield return new WaitForSeconds(timeToBreakDance);
        animator.SetBool("BreakDance2", true);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DialogueSistem.instance.HideDialogue();
            StopCoroutine(Talk());
        }
    }

    IEnumerator Talk()
    {
        DialogueSistem.instance.ShowDialogue(dialogues[0]);
        yield return new WaitForSeconds(timeToWait);
        DialogueSistem.instance.ShowDialogue(dialogues[1]);
        yield return new WaitForSeconds(0.1f);
        talk = true;
        if (boss)
        {
            StartCoroutine(feliz());
            yield return new WaitForSeconds(4f);
            //GameManager.boss = true;
        }
        yield break;
    }
}
