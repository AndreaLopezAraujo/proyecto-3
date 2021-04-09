using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public AnimationCurve animy;
    Keyframe[] ks;
    void Start ()
    {
        Camera.main.transform.position=new Vector3(2.67f, 1.28f, -9.84f);
    }
void SetObliqueness(float horizObl, float vertObl) {
        Matrix4x4 mat  = Camera.main.projectionMatrix;
        mat[0, 2] = horizObl;
        mat[1, 2] = vertObl;
        Camera.main.projectionMatrix = mat;
    }
    void Update()
    {
        //if ( Input.GetKeyDown ( KeyCode.Space ))
        //{
            //print ("se presionó la tecla de espacio");
            //float horizObl=0f;
            //float vertObl=-1f;
            //SetObliqueness(horizObl, vertObl);  
        //}
        //if ( Input.GetKeyDown ( KeyCode.UpArrow ))
        //{
            //print ("se presionó la tecla de flecha arriba");
            //Camera.main.transform.position=new Vector3(2.81f, 2.7f, -8.68f);  
        //}
    }
}