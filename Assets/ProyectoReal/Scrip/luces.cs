using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luces : MonoBehaviour
{
   Light lightComp;
   Color base1 = new Color(0.95f, 0.87f, 0.81f);
   Color detalle1 = new Color(0.4f, 0.8f, 0.3f);
   float intensidad= 1.0f; //Intensidad de la luz (línea 30)
    void Start()
    {
        // Make a game object
        GameObject lightGameObject = new GameObject("The Light");

        // Add the light component
        Light lightComp1 = lightGameObject.AddComponent<Light>();
        lightComp=lightComp1;
        lightComp.type = LightType.Directional; 
        lightComp.shadows = LightShadows.Soft; 

        // Set color and position
        lightComp.color = base1;


        // Set the position (or any transform property)
        lightGameObject.transform.position = new Vector3(3.57f,1.11f, -9.68f);
    }
   void Update()
    {
        lightComp.intensity = Mathf.PingPong ( Time.time , 2);
       if ( Input.GetKeyDown ( KeyCode.RightArrow )){
             Debug.Log ("Se presionó la tecla de flecha derecha"); 
             lightComp.color = detalle1;
       }
       if ( Input.GetKeyDown ( KeyCode.LeftArrow )){
             Debug.Log ("Se presionó la tecla de flecha izquierda"); 
             lightComp.color = base1;
       }


    }
}