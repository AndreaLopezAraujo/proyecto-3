using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planos : MonoBehaviour
{
     public AnimationCurve animy;
    Color detalle1 = new Color(0.4f, 0.8f, 0.3f);
    // Start is called before the first frame update
    public  GameObject plane;
    void Start()
    {
        planoFondo();
    }
    void planoFondo()
    {
        Vector3 vc1;
        Vector3 vc3;
        Color c1;
        vc1=new Vector3(2f, -0.47f, -4.26f);
        vc3=new Vector3(10f ,1f,10f);
        c1=detalle1;
        plane  = GameObject.CreatePrimitive(PrimitiveType.Cube);
        plane.transform.position = vc1;
        plane.transform.localScale = vc3;
        plane.transform.Rotate (0.0f, 0f, 0f, Space.Self );
        var planeRenderer0 = plane.GetComponent<Renderer>();
        var texture = Resources.Load<Texture2D>("pasto");
        planeRenderer0.material.mainTexture =texture;
        planeRenderer0.material.SetColor("_Color", c1);
        plane.name="plano";
    }

    // Update is called once per frame
    void Update()
    {
        animy = new AnimationCurve(new Keyframe(0, 5f),new Keyframe(1, 2f),new Keyframe(2, -0.97f));
        Vector3 vec=GameObject.Find("plano").transform.position;
        float x=vec[0];
        float z=vec[2];
        plane.transform.position = new Vector3(x, animy.Evaluate(Time.time), z);
    }
}
