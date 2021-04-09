using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //Cubo parte de adelante
        GameObject cube0 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube0.transform.position = new Vector3(-2.5F, -0.3F, 0);
        cube0.transform.localScale = new Vector3(1, 0.5F,1);
        //Cubos largos  
        GameObject cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(0, 0, 0);
        cube1.transform.localScale = new Vector3(5, 1.1f,1);
        GameObject cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(8, 0, 0);
        cube2.transform.localScale = new Vector3(5, 1.1f,1);
        GameObject cube3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube3.transform.position = new Vector3(16, 0, 0);
        cube3.transform.localScale = new Vector3(5, 1.1f,1);
        
        //Cubos cortos
        GameObject cube4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube4.transform.position = new Vector3(3, 0, 0);
        cube4.transform.localScale = new Vector3(1, 0.9f,1);
        GameObject cube5 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube5.transform.position = new Vector3(4, 0, 0);
        cube5.transform.localScale = new Vector3(1, 1,1);
        GameObject cube6 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube6.transform.position = new Vector3(5, 0, 0);
        cube6.transform.localScale = new Vector3(1, 0.9f,1);

        GameObject cube7 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube7.transform.position = new Vector3(11, 0, 0);
        cube7.transform.localScale = new Vector3(1, 0.9f,1);
        GameObject cube8 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube8.transform.position = new Vector3(12, 0, 0);
        cube8.transform.localScale = new Vector3(1, 1,1);
        GameObject cube9 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube9.transform.position = new Vector3(13, 0, 0);
        cube9.transform.localScale = new Vector3(1, 0.9f,1);

       //Get the Renderer component from the new cube
       var cubeRenderer1 = cube1.GetComponent<Renderer>();
       var cubeRenderer2 = cube2.GetComponent<Renderer>();
       var cubeRenderer3 = cube3.GetComponent<Renderer>();
       var cubeRenderer0 = cube0.GetComponent<Renderer>();

       //Call SetColor using the shader property name "_Color" and setting the color to red
       cubeRenderer1.material.SetColor("_Color", Color.red);
       cubeRenderer2.material.SetColor("_Color", Color.red);
       cubeRenderer3.material.SetColor("_Color", Color.red);
       cubeRenderer0.material.SetColor("_Color", Color.red);
       cilindres();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void cilindres()
    {
        //Bagon 1
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = new Vector3(-2, -0.5f, 0);
        cylinder1.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder1.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder2.transform.position = new Vector3(0, -0.5f, 0);
        cylinder2.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder2.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder3.transform.position = new Vector3(2, -0.5f, 0);
        cylinder3.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder3.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);

       //Bagon 2
        GameObject cylinder4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder4.transform.position = new Vector3(6, -0.5f, 0);
        cylinder4.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder4.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder5 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder5.transform.position = new Vector3(8, -0.5f, 0);
        cylinder5.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder5.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder6 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder6.transform.position = new Vector3(10, -0.5f, 0);
        cylinder6.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder6.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);

        //Bagon 3
        GameObject cylinder7 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder7.transform.position = new Vector3(14, -0.5f, 0);
        cylinder7.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder7.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder8 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder8.transform.position = new Vector3(16, -0.5f, 0);
        cylinder8.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder8.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       GameObject cylinder9 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder9.transform.position = new Vector3(18, -0.5f, 0);
        cylinder9.transform.Rotate (90.0f, 0.0f, 0.0f, Space.Self );
       cylinder9.transform.localScale = new Vector3(0.5f, 0.7f,0.4f);
       
       //Get the Renderer component from the new cube
       var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        var cylinderRenderer2 = cylinder2.GetComponent<Renderer>();
         var cylinderRenderer3 = cylinder3.GetComponent<Renderer>();
          var cylinderRenderer4 = cylinder4.GetComponent<Renderer>();
           var cylinderRenderer5 = cylinder5.GetComponent<Renderer>();
            var cylinderRenderer6 = cylinder6.GetComponent<Renderer>();
             var cylinderRenderer7 = cylinder7.GetComponent<Renderer>();
              var cylinderRenderer8 = cylinder8.GetComponent<Renderer>();
               var cylinderRenderer9 = cylinder9.GetComponent<Renderer>();

       //Call SetColor using the shader property name "_Color" and setting the color to red
       cylinderRenderer1.material.SetColor("_Color", Color.black);
       cylinderRenderer2.material.SetColor("_Color", Color.black);
       cylinderRenderer3.material.SetColor("_Color", Color.black);
       cylinderRenderer4.material.SetColor("_Color", Color.black);
       cylinderRenderer5.material.SetColor("_Color", Color.black);
       cylinderRenderer6.material.SetColor("_Color", Color.black);
       cylinderRenderer7.material.SetColor("_Color", Color.black);
       cylinderRenderer8.material.SetColor("_Color", Color.black);
       cylinderRenderer9.material.SetColor("_Color", Color.black);
    }
}
