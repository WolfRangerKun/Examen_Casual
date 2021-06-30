using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Color col = new Color(0, 1, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(suma());
    }

    // Update is called once per frame
    void Update()
    {
    }
    IEnumerator suma()
    {
        Debug.Log("oli");
        GetComponent<SpriteRenderer>().color = new Color(0, .5f, .2f, .5f);
        yield return new WaitForSeconds(3);
        Debug.Log("oli2");
        GetComponent<SpriteRenderer>().color += new Color(1, .4f, .2f, .1f);
        yield return new WaitForSeconds(3);
        Debug.Log("oli3");
        GetComponent<SpriteRenderer>().color -= new Color(.5f, .2f, .3f, .4f);
    }
}
