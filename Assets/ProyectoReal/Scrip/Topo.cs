using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topo : MonoBehaviour
{
    Color cafeClaro = new Color(0.5f, 0.3f, 0.07f);
    // Start is called before the first frame update
    void Start()
    {
        GameObject topo=GameObject.Find("Topo especial");
        var topoRenderer0 = topo.GetComponent<Renderer>();
        topoRenderer0.material.SetColor("_Color", cafeClaro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
