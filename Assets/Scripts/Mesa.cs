using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mesa : MonoBehaviour
{
    public int crearDioxido;
    public int crearAcidoCarbonico;
    public List<GameObject> mesa;
    public GameObject panel;
    bool activedPanel = false;
    bool mesaActivada;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Inventario inventario = other.GetComponent<Inventario>();
            foreach (GameObject g in inventario.inventario)
            {
                inventario.inventario.Remove(g);
                mesa.Add(g);
                return;
            }
            
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mesaActivada = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            mesaActivada = false;
        }
    }
    //private T GetChildComponentByName<T>(string name) where T : Mesa
    //{
    //    foreach (T component in GetComponentsInChildren<T>(true))
    //    {
    //        if (component.gameObject.name == name)
    //        {
    //            return component;
    //        }
    //    }
    //    return null;
    //}
    private void Update()
    {
        if (mesaActivada)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ActivePanel();
            }
        }
       
        if (activedPanel)
        {
            ShowPanel();
        }
        else
        {
            HidePanel();
        }
        //Atomos
        //for (int i = 0; i < mesa.Count; i++)
        //{
        //    if (mesa[i].gameObject.name == "Oxigeno")
        //    {
        //        crearDioxido++;
        //        crearAcidoCarbonico++;
        //        mesa.Remove(mesa[i]);
        //        return;
        //    }
        //    if (mesa[i].gameObject.name == "Carbono")
        //    {

        //        crearDioxido++;
        //        crearAcidoCarbonico++;
        //        mesa.Remove(mesa[i]);
        //        return;
        //    }
        //    if (mesa[i].gameObject.name == "Vaso")
        //    {
        //        crearAcidoCarbonico++;
        //        crearAcidoCarbonico++;
        //        mesa.Remove(mesa[i]);

        //    }
        //}

        //if (mesa[1].gameObject.name == "Oxigeno")
        //{
        //    crearDioxido++;
        //    crearAcidoCarbonico++;
        //    mesa.Remove(mesa[1]);
        //    Debug.Log("ORDEN");
        //    return;
        //}
    }

    public GameObject spawnMoleculas;
    public List<GameObject> moleculas;
    public void SpawnDioxido()
    {
        if (mesa[0].gameObject.name == "Carbono" && mesa[1].gameObject.name == "Oxigeno")
        {
            Instantiate(moleculas[0], spawnMoleculas.transform.position, Quaternion.identity);
            mesa.Remove(mesa[0]);
            mesa.Remove(mesa[0]);
        }
    }

    public void SpawnAcidoCarbonico()
    {
        if (mesa[0].gameObject.name == "Vaso" && mesa[1].gameObject.GetComponent<Molecula>().tipoMolecula == Molecula.TIPO_ATOMO.DIOXIDO)
        {
            if (mesa[0].gameObject.GetComponent<Vaso>().cantidadAgua == 2)
            {
                Instantiate(moleculas[1], spawnMoleculas.transform.position, Quaternion.identity);
                mesa.Remove(mesa[0]);
                mesa.Remove(mesa[0]);
            }
        }
    }

    
    void ActivePanel()
    {
        activedPanel = !activedPanel;
        //return;
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }

    void HidePanel()
    {
        panel.SetActive(false);
    }
}
