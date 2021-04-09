using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 v1 = new Vector3(-2, 1, 0);
        Vector3 v2 = new Vector3(0.5f, 5, 0.5f);
        float x1=0f;
        float x2=0f;
        float x3=85f;
        Color c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(3.86f, -1.58f, -0.16f);
        v2 = new Vector3(0.2f, 3, 0.2f);
        x1=0f;
        x2=0f;
        x3=30f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(5.71f, -4.07f, 0.08f);
        v2 = new Vector3(5f, 0.1f, 5f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.black;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-7.23f, 0.28f, -0.16f);
        v2 = new Vector3(0.2f, 3, 0.2f);
        x1=0f;
        x2=0f;
        x3=-20f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-8.54f, -2.79f, 0.08f);
        v2 = new Vector3(5f, 0.1f, 5f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.black;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(1.55f, 1.29f, 0.21f);
        v2 = new Vector3(0.3f, 0.5f, 0.3f);
        x1=0f;
        x2=0f;
        x3=0f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(1.56f, 1.74f, -0.16f);
        v2 = new Vector3(0.8f, 0.1f, 1.5f);
        x1=0f;
        x2=0f;
        x3=0f;
        c=Color.black;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-6.23f, 2.92f, 0.08f);
        v2 = new Vector3(0.1f, 1f, 0.1f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-6.23f, 2.92f, -0.87f);
        v2 = new Vector3(0.3f, 0.1f, 0.3f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.red;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-6.23f, 2.92f, 1.23f);
        v2 = new Vector3(0.3f, 0.1f, 0.3f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.red;
        cilinder(v1,v2,x1,x2,x3,c);
        v1 = new Vector3(-3.52f, -0.76f, -0.16f);
        v2 = new Vector3(0.2f, 2.4f, 0.2f);
        x1=0f;
        x2=0f;
        x3=30f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-1.15f, -0.93f, -0.16f);
        v2 = new Vector3(0.2f, 2, 0.2f);
        x1=0f;
        x2=0f;
        x3=-30f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-2.3f, -2.85f, -0.21f);
        v2 = new Vector3(2f, 0.1f, 2f);
        x1=90f;
        x2=0f;
        x3=0f;
        c=Color.black;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-2.94f, -3.73f, -0.31f);
        v2 = new Vector3(0.2f, 0.8f, 0.2f);
        x1=0f;
        x2=0f;
        x3=-30f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-1.87f, -3.9f, 0.01f);
        v2 = new Vector3(0.2f, 0.8f, 0.2f);
        x1=0f;
        x2=0f;
        x3=30f;
        c=Color.blue;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-3.49f, -4.33f, -0.31f);
        v2 = new Vector3(0.5f, 0.1f, 1f);
        x1=0f;
        x2=0f;
        x3=0f;
        c=Color.red;
        cilinder(v1,v2,x1,x2,x3,c);

        v1 = new Vector3(-1.47f, -4.65f, -0.31f);
        v2 = new Vector3(0.5f, 0.1f, 1f);
        x1=0f;
        x2=0f;
        x3=0f;
        c=Color.red;
        cilinder(v1,v2,x1,x2,x3,c);
    }

    // Update is called once per frame
    void cilinder(Vector3 v1, Vector3 v2,float x1,float x2,float x3,Color c)
    {
         GameObject c1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        c1.transform.position = v1;
        c1.transform.localScale=v2;
        c1.transform.Rotate (x1, x2, x3, Space.Self );
        var cRenderer1 = c1.GetComponent<Renderer>();
        cRenderer1.material.SetColor("_Color", c);
    }
}
