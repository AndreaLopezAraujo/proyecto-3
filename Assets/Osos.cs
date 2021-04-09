using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osos : MonoBehaviour
{
    Color base1 = new Color(0.95f, 0.87f, 0.81f);
    Color detalle1 = new Color(0.95f, 0.75f, 0.57f);
    Color detalle2 = new Color(0.85f, 0.59f, 0.36f);
    
    // Start is called before the first frame update
    void Start()
    {
        Cabeza();
        Cuerpo();


    }
    void Cuerpo()
    {
        float xbaseC=-0.77f;
        float ybaseC=1.03f;
        float zbaseC=-4.31f;
        Vector3 vc1=new Vector3(xbaseC, 1.03f, zbaseC);
        Vector3 vc3=new Vector3(1f ,0.2f,1f);
        Color c1=base1;
        Vector3 vc2=new Vector3(xbaseC, 1.17f, -4.315f);
        Vector3 vc4=new Vector3(0.7f ,0.2f,0.7f);
        Color c2=detalle1;
        BaseCuerpo(vc1,vc2,vc3,vc4,c1,c2);

        vc1=new Vector3(-1.308f, 1.343f, -4.409f);
        vc3=new Vector3(0.3f ,0.3f,0.2f);
        c1=base1;
        vc2=new Vector3(-0.264f, 1.392f, -4.409f);
        vc4=new Vector3(0.3f ,0.3f,0.2f);
        Brazos(vc1,vc2,vc3,vc4,c1);

        vc1=new Vector3(-1.122f, 0.575f, -4.384f);
        vc3=new Vector3(0.3f ,0.3f,0.2f);
        c1=base1;
        vc2=new Vector3(-0.373f, 0.538f, -4.377f);
        vc4=new Vector3(0.3f ,0.3f,0.2f);
        Piernas(vc1,vc2,vc3,vc4,c1);
        
    }
    void Piernas(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1)
    {
        GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.transform.position = vc1;
        cube0.transform.localScale = vc3;
        cube0.transform.Rotate (0.0f, 0.0f, -30f, Space.Self );
        var cubeRenderer0 = cube0.GetComponent<Renderer>();
        cubeRenderer0.material.SetColor("_Color", c1);
        
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = vc2;
        cube1.transform.localScale = vc4;
        cube1.transform.Rotate (0.0f, 0.0f, -50f, Space.Self );
        var cubeRenderer1 = cube1.GetComponent<Renderer>();
        cubeRenderer1.material.SetColor("_Color", c1);
    }
    void Brazos(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1)
    {
        GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.transform.position = vc1;
        cube0.transform.localScale = vc3;
        cube0.transform.Rotate (0.0f, 0.0f, -30f, Space.Self );
        var cubeRenderer0 = cube0.GetComponent<Renderer>();
        cubeRenderer0.material.SetColor("_Color", c1);
        
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = vc2;
        cube1.transform.localScale = vc4;
        cube1.transform.Rotate (0.0f, 0.0f, -50f, Space.Self );
        var cubeRenderer1 = cube1.GetComponent<Renderer>();
        cubeRenderer1.material.SetColor("_Color", c1);
    }
    void BaseCuerpo(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1, Color c2)
    {
        GameObject cylinder0 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder0.transform.position = vc1;
        cylinder0.transform.localScale = vc3;
        cylinder0.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer0 =   cylinder0.GetComponent<Renderer>();
        cylinderRenderer0.material.SetColor("_Color", c1);

        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc2;
        cylinder1.transform.localScale = vc4;
        cylinder1.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer1 =   cylinder1.GetComponent<Renderer>();
        cylinderRenderer1.material.SetColor("_Color", c2);

    }
    void Cabeza()
    {
        Orejas();

        Vector3 vc1=new Vector3(-0.77f, 1.789f, -4.309f);
        Vector3 vc2=new Vector3(0.7f ,0.2f,0.7f);
        Color c1=base1;
        BaseCabeza(vc1,vc2,c1);
        
        vc1=new Vector3(-0.928f, 1.92f, -4.312f);
        vc2=new Vector3(-0.63f, 1.92f, -4.314f);
        Vector3 vc3=new Vector3(0.1f ,0.2f,0.1f);
        Vector3 vc4=new Vector3(0.1f ,0.2f,0.1f);
        c1=detalle2;
        Ojos(vc1,vc2,vc3,vc4,c1);

        vc1=new Vector3(-0.779f, 1.633f, -4.312f);
        vc2=new Vector3(-0.779f, 1.732f, -4.314f);
        vc3=new Vector3(0.4f ,0.2f,0.4f);
        vc4=new Vector3(0.2f ,0.2f,0.2f);
        c1=detalle1;
        Color c2=detalle2;
        Nariz(vc1,vc2,vc3,vc4,c1,c2);
    }
    void Ojos(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.localScale = vc3;
        cylinder1.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer1 =   cylinder1.GetComponent<Renderer>();
        cylinderRenderer1.material.SetColor("_Color", c1);

        GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.position = vc2;
        cylinder2.transform.localScale = vc4;
        cylinder2.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer2 =   cylinder2.GetComponent<Renderer>();
        cylinderRenderer2.material.SetColor("_Color", c1);
    }
    void BaseCabeza(Vector3 vc1,Vector3 vc2, Color c1)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.localScale = vc2;
        cylinder1.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer1 =   cylinder1.GetComponent<Renderer>();
        cylinderRenderer1.material.SetColor("_Color", c1);   
    }
    void Nariz(Vector3 vc1,Vector3 vc2, Vector3 vc3,Vector3 vc4, Color c1, Color c2)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.localScale = vc3;
        cylinder1.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer1 =   cylinder1.GetComponent<Renderer>();
        cylinderRenderer1.material.SetColor("_Color", c1);

        GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.position = vc2;
        cylinder2.transform.localScale = vc4;
        cylinder2.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer2 =   cylinder2.GetComponent<Renderer>();
        cylinderRenderer2.material.SetColor("_Color", c2);
    }
    void Orejas()
    {
        Vector3 vc1=new Vector3(-1.035f, 2.05f, -4.242f);
        Vector3 vc2=new Vector3(-1.035f, 2.05f, -4.267f);
        Vector3 vc4=new Vector3(0.3f ,0.2f,0.3f);
        Vector3 vc5=new Vector3(0.2f ,0.2f,0.2f);
        Color c1=base1;
        Color c2=detalle1;
        Oreja(vc1,vc2,vc4,vc5,c1,c2);

        vc1=new Vector3(-0.541f, 2.05f, -4.242f);
        vc2=new Vector3(-0.541f, 2.05f, -4.267f);
        vc4=new Vector3(0.3f ,0.2f,0.3f);
        vc5=new Vector3(0.2f ,0.2f,0.2f);
        c1=base1;
        c2=detalle1;
        Oreja(vc1,vc2,vc4,vc5,c1,c2);
    }
    void Oreja(Vector3 vc1,Vector3 vc2, Vector3 vc4,Vector3 vc5, Color c1, Color c2)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = vc1;
        cylinder1.transform.localScale = vc4;
        cylinder1.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinderRenderer1.material.SetColor("_Color", c1);

        GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.position = vc2;
        cylinder2.transform.localScale = vc5;
        cylinder2.transform.Rotate (0.0f, 90f, 90f, Space.Self );
        var cylinderRenderer2 = cylinder2.GetComponent<Renderer>();
        cylinderRenderer2.material.SetColor("_Color", c2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    float diferencia( float v1, float v2)
    {
        return v1-v2;
    }

    float diferenciaEscala( float v1, float v2)
    {
        return v2/v1;
    }
}
