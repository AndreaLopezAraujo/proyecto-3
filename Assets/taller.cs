using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taller : MonoBehaviour
{
    public GameObject object1;
    void Start() {
        Plantas();
    }
    void Plantas()
    {
        // plantas acuaticas claras
         Vector3 v1=new Vector3(0f, 0f, 0f);
         Vector3 v2=new Vector3(1f ,1f,1f);
         Color c=new Color(0.7f, 0.8f, 0.3f);
         planta(v1,v2,c);
    }
    void planta(Vector3 v1, Vector3 v2, Color c)
    {
        GameObject cylinder1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder1.transform.position = v1;
        cylinder1.transform.Rotate (0.0f, 0.0f, 0.0f, Space.Self );
        object1=cylinder1;
        var cylinderRenderer1 = cylinder1.GetComponent<Renderer>();
        cylinder1.transform.localScale = v2;
        Color color = c;
        cylinderRenderer1.material.SetColor("_Color", color);
    }
    void Update () {
        if ( Input.GetKeyDown ( KeyCode.Space ))
        {
            var cylinderRenderer1 = object1.GetComponent<Renderer>();
            print ("se presionó la tecla de espacio");
            Color c=new Color(0.32f, 0.68f, 0.84f);
            Color color = c;
            Vector3 v1=new Vector3(1f, 1f, 1f);
            Vector3 v2=new Vector3(2f ,2f,2f);
            object1.transform.position = v1;
            object1.transform.localScale = v2;
            cylinderRenderer1.material.SetColor("_Color", color);
        }
    }
}
 