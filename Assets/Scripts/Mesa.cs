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
            //SpawnBotones
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ActivePanel();
            }
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
        if (activedPanel)
        {
            ShowPanel();
        }
        else
        {
            HidePanel();
        }
        //Atomos
        for (int i = 0; i < mesa.Count; i++)
        {
            if (mesa[i].gameObject.name == "Oxigeno")
            {
                mesa.Remove(mesa[i]);
                crearDioxido++;
                crearAcidoCarbonico++;
                return;
            }
            if (mesa[i].gameObject.name == "Carbono")
            {
                mesa.Remove(mesa[i]);
                crearDioxido++;
                crearAcidoCarbonico++;
                return;
            }
            if (mesa[i].gameObject.name == "Vaso")
            {
                mesa.Remove(mesa[i]);
                crearAcidoCarbonico++;
                crearAcidoCarbonico++;
            }
        }


    }

    public GameObject spawnMoleculas;
    public List<GameObject> moleculas;
    public void SpawnDioxido()
    {
        if(crearDioxido >= 2)
        {
            crearDioxido--;
            crearDioxido--;
            Instantiate(moleculas[0], spawnMoleculas.transform.position, Quaternion.identity);
        }
    }

    public void SpawnAcidoCarbonico()
    {
        if (crearAcidoCarbonico >= 4)
        {
            crearDioxido--;
            crearDioxido--;
            crearAcidoCarbonico--;
            crearAcidoCarbonico--;
            crearAcidoCarbonico--;
            crearAcidoCarbonico--;
            Instantiate(moleculas[1], spawnMoleculas.transform.position, Quaternion.identity);
        }
    }

    void ActivePanel()
    {
        activedPanel = !activedPanel;
        return;
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
