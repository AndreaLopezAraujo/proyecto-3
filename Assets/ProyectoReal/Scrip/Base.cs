using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    Color azulOscuro = new Color(0.32f, 0.68f, 0.84f);
    // Start is called before the first frame update
    void Start()
    {
        GameObject topo=GameObject.Find("Base");
        var topoRenderer0 = topo.GetComponent<Renderer>();
        topoRenderer0.material.SetColor("_Color", azulOscuro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}