using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Huecos : MonoBehaviour
{
     Color detalle1 = new Color(0.047f, 0.078f, 0.047f);
    public AnimationCurve animy;
    // Start is called before the first frame update
    void Start()
    {
        float x=3.77f;
        float z=-4.97f;
        crearHueco(x,z,"hueco23");

        x=x-1.80f;
        z=-4.97f;
        crearHueco(x,z,"hueco22");

        x=x-1.75f;
        z=-4.97f;
        crearHueco(x,z,"hueco21");

        x=3.72f;
        z=-3.325f;
        crearHueco(x,z,"hueco33");

        x=x-1.75f;
        z=-3.325f;
        crearHueco(x,z,"hueco32");

        x=x-1.75f;
        z=-3.325f;
        crearHueco(x,z,"hueco31");

    }
    void crearHueco(float x,float z,string no)
    {
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(x, -1.46f, z);
        cylinder.transform.localScale = new Vector3(1.5f, 1, 1.5f);
        cylinder.name=no;
        var cylinderRenderer0 = cylinder.GetComponent<Renderer>();
        var texture = Resources.Load<Texture2D>("hueco");
        print(texture);
        cylinderRenderer0.material.mainTexture =texture;
        cylinderRenderer0.material.SetColor("_Color", detalle1);
        //cylinderRenderer0.material.color= Color.black;
    }
    void animar(string n)
    {
        animy = new AnimationCurve(new Keyframe(0, 4.72f),new Keyframe(1, 1.63f),new Keyframe(2, -1.46f));
        Vector3 vec=GameObject.Find(n).transform.position;
        float x=vec[0];
        float z=vec[2];
        GameObject topo=GameObject.Find(n);
        topo.transform.position = new Vector3(x, animy.Evaluate(Time.time), z);
    }

    // Update is called once per frame
    void Update()
    {
        animar("hueco23");
        animar("hueco22");
        animar("hueco21");
        animar("hueco31");
        animar("hueco32");
        animar("hueco33");

    }
}
