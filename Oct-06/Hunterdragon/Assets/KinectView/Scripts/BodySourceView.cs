using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Kinect = Windows.Kinect;

public class BodySourceView : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BodySourceManager;
    public Material BoneMaterial; //borrar si no funca
    private BodySourceManager _BodyManager;

    public Transform flechaPrefab;
    public Transform flechaActual;
    public float fuerzaLanzamiento = 10f;
    private bool flechaEnVuelo = false;
    


    //Game Object


    //public Transform Spine_base;
    //public Transform Spine_mid;
    //public Transform Neck;
    //public Transform Head;
    /*public Transform Shoulder_left;
    public Transform Elbow_left;
   // public Transform Wrist_left;
    public Transform Shoulder_right;
    public Transform Elbow_right;
    //public Transform Wrist_right;
    
    //public Transform Hip_left;
    //public Transform Knee_left;
    //public Transform Ankle_left;
    //public Transform Foot_left;
    //public Transform Hip_right;
    //public Transform Knee_right;
    //public Transform Ankle_right;
    //public Transform Foot_right;
    //public Transform Spines_shoulder;
    */


    // mano izquierda
    public Transform HandTip_left;
    public Transform Thumb_left;

    // mano derecha
    public Transform HandTip_right;
    public Transform Thumb_right;

    public Transform Hand_right;
    public Transform Hand_left;
    void Start()
    {
        if (BodySourceManager == null)
        {
            Debug.Log("No hay script");
            return;
        }

        _BodyManager = BodySourceManager.GetComponent<BodySourceManager>();
        if (_BodyManager == null)
        {
            Debug.Log("No hay clase");
            return;
        }
    }
    void LanzarFlecha()
    {
        Debug.Log("LANZANDO FLECHA");
        // Calcula la dirección y la velocidad en función de la diferencia entre las manos
        Vector3 direccionLanzamiento = (Hand_left.localPosition - Hand_right.localPosition).normalized;
        Vector3 velocidadLanzamiento = direccionLanzamiento * fuerzaLanzamiento;
        Debug.Log("Direction: " + velocidadLanzamiento);


        // Crea la flecha y configura su posición y velocidad inicial
        flechaActual = Instantiate(flechaPrefab, Hand_left.localPosition, Quaternion.identity);
        Rigidbody rb = flechaActual.GetComponent<Rigidbody>();
        rb.velocity = velocidadLanzamiento;
        rb.useGravity = true;

        // Establece la flecha como en vuelo
        flechaEnVuelo = true;
    }
    // Update is called once per frame
    void Update()
    {
        //Spine_base.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.SpineBase);
        //Spine_mid.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.SpineMid);
        //Neck.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.Neck);
        //Head.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.Head);
        //Wrist_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.WristLeft);
        //Hand_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HandLeft);
        
        //Wrist_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.WristRight);


  

        //Wrist
        //Vector3 myvect3 = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.WristLeft);
       // Wrist_left.localPosition = myvect3;
        //Debug.Log("WL: " + myvect3);

        //Vector3 myvect4 = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.WristRight);
        //Wrist_right.localPosition = myvect4;
        //Debug.Log("WR: " + myvect4);

        //HANDTIP
        HandTip_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HandTipLeft);
        //Debug.Log("HTL: " + myvect5);

        HandTip_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HandTipRight);
        //Debug.Log("HTR: " + myvect6);

        //THUMBS
        Vector3 myvect7 = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ThumbLeft);
        Thumb_left.localPosition = myvect7;
        //Debug.Log("TL: " + myvect7);

        Vector3 myvect8 = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ThumbRight);
        Thumb_right.localPosition = myvect8;
        //Debug.Log("TR: " + myvect8);
/*
        //ARMS

        Shoulder_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ShoulderLeft);
        Elbow_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ElbowLeft);

        Shoulder_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ShoulderRight);
        Elbow_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.ElbowRight);

        */
        //HANDS
        Hand_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HandRight);
        //Debug.Log("HR: " + Hand_right.localPosition);

        Vector3 myvect2 = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HandLeft);
        Hand_left.localPosition = myvect2;
        //Debug.Log("HL: " + myvect2);
        //Hip_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HipLeft);
        //Knee_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.KneeLeft);
        //Ankle_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.AnkleLeft);
        //Foot_left.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.FootLeft);
        //Hip_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.HipRight);
        //Knee_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.KneeRight);
        //Ankle_right.localPosition = _BodyManager.GetBodyJointPosModded(Windows.Kinect.JointType.AnkleRight);

        float distancia = Vector3.Distance(HandTip_left.localPosition, Thumb_left.localPosition);
        

        // Imprimir la distancia en la consola
        Debug.Log("Distancia entre HandTip_left y Thumb_left: " + distancia);
        if(distancia > 4.5)
        {
            //soltar
            LanzarFlecha();
            
            
        }


    }
    
  

    private GameObject CreateBodyObject(ulong id)
    {
        GameObject body = new GameObject("Body:" + id);


        for (Kinect.JointType jt = Kinect.JointType.ThumbRight; jt <= Kinect.JointType.ThumbLeft; jt++)
        {
            GameObject jointObj = GameObject.CreatePrimitive(PrimitiveType.Cube);

            LineRenderer lr = jointObj.AddComponent<LineRenderer>();
            lr.SetVertexCount(2);
            lr.material = BoneMaterial;
            lr.SetWidth(0.05f, 0.05f);

            jointObj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            jointObj.name = jt.ToString();
            jointObj.transform.parent = body.transform;
        }

        return body;
    }
}
