using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topos : MonoBehaviour
{
    public AnimationCurve animy;
    Color cafeClaro = new Color(0.5f, 0.3f, 0.07f);
    Color detalle1 = new Color(0.95f, 0.87f, 0.81f);
    Keyframe[] ks;
    // Start is called before the first frame update
    void Start()
    {
        float x;
        float z;
        x=2;
        z=-4.96f;
        crearTopo(x,z,"Topo22");
        
        x=x-1.77f;
        z=-4.96f;
        crearTopo(x,z,"Topo21");

        x=3.8f;
        z=-3.46f;
        crearTopo(x,z,"Topo33");

        x=x-1.77f;
        z=-3.46f;
        crearTopo(x,z,"Topo32");

        x=x-1.77f;
        z=-3.46f;
        crearTopo(x,z,"Topo31");
    }
    void crearTopo(float x,float z,string no)
    {
        GameObject topo = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        topo.transform.position = new Vector3(x, -0.92f, z);
        var topoRenderer0 = topo.GetComponent<Renderer>();
        var texture = Resources.Load<Texture2D>("topo");
        topoRenderer0.material.mainTexture =texture;
        topoRenderer0.material.SetColor("_Color", cafeClaro);
        topo.name=no;
    }
    void animar(string n)
    {
        animy = new AnimationCurve(new Keyframe(0, -2.26f),new Keyframe(1, -0.43f), new Keyframe(2, -1.1f));
        animy.preWrapMode = WrapMode.PingPong;
        animy.postWrapMode = WrapMode.PingPong;
        Vector3 vec=GameObject.Find(n).transform.position;
        float x=vec[0];
        float z=vec[2];
        GameObject topo=GameObject.Find(n);
        topo.transform.position = new Vector3(x, animy.Evaluate(Time.time), z);
    }
    void animar2(string n, float v, float blanco)
    {
        ks = new Keyframe[960];
        var i = 0;
        for(i=0;i<blanco;i++)
        {
            float valor=-2.76f;
            ks[i] = new Keyframe(i, valor);
        }
        while (i < ks.Length-2)
        {
            float valor=-2.76f;
            ks[i] = new Keyframe(i, valor);
            valor=-0.43f*v;
            i++;
            ks[i] = new Keyframe(i, valor);
            valor=-0.40f*v;
            i++;
            ks[i] = new Keyframe(i, valor);
            i++;
        }
        animy = new AnimationCurve(ks);
        animy.preWrapMode = WrapMode.PingPong;
        animy.postWrapMode = WrapMode.PingPong;
        Vector3 vec=GameObject.Find(n).transform.position;
        float x=vec[0];
        float z=vec[2];
        GameObject topo=GameObject.Find(n);
        topo.transform.position = new Vector3(x, animy.Evaluate(Time.time), z);
    }
    void cambiarTextura(string n, Color col)
    {
        GameObject topo=GameObject.Find(n);
        var topoRenderer0 = topo.GetComponent<Renderer>();
        var texture = Resources.Load<Texture2D>("topo");
        topoRenderer0.material.mainTexture =texture;
        topoRenderer0.material.SetColor("_Color",col);
    }
    // Update is called once per frame
    void Update()
    {
        animar("Topo22"); 
        animar("Topo21");
        animar2("Topo33",0.9f,3); 
        animar2("Topo32",0.2f,8); 
        animar2("Topo31",0.9f,7);     
        if ( Input.GetKeyDown ( KeyCode.UpArrow ))
        {
            print ("se presionó la tecla de flecha arriba");
            cambiarTextura("Topo22",detalle1);  
            cambiarTextura("Topo32",detalle1); 
            cambiarTextura("Topo31",detalle1);
        }
        if ( Input.GetKeyDown ( KeyCode.DownArrow ))
        {
            print ("se presionó la tecla de flecha abajo");
            cambiarTextura("Topo22",cafeClaro );  
            cambiarTextura("Topo32",cafeClaro); 
            cambiarTextura("Topo33",cafeClaro); 
            cambiarTextura("Topo31",cafeClaro);
        }
    }
}
