using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mazo : MonoBehaviour
{
     Color detalle1 = new Color(0.95f, 0.75f, 0.57f);
     Color detalle2 = new Color(0.85f, 0.59f, 0.36f);
    // Start is called before the first frame update
    void Start()
    {
        GameObject topo=GameObject.Find("Mazo");
        var topoRenderer0 = topo.GetComponent<Renderer>();
        topoRenderer0.material.SetColor("_Color", detalle1);
        GameObject topo1=GameObject.Find("Cabeza");
        var topoRenderer = topo1.GetComponent<Renderer>();
        topoRenderer.material.SetColor("_Color", detalle2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}